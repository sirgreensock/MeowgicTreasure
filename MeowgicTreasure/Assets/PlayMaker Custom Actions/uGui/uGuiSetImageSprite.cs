// (c) Copyright HutongGames, LLC 2010-2014. All rights reserved.
//--- __ECO__ __ACTION__ ---//

using UnityEngine;
using uUI = UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("uGui")]
	[Tooltip("Sets the Sprite value of a UGui Image component. With reset on exit option ")]
	public class uGuiSetImageSprite : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(uUI.Image))]
		[Tooltip("The GameObject with the ui component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		//[UIHint(UIHint.TextArea)]
		[Tooltip("The new Sprite of the UGui component.")]
		public Sprite spriteToSwap;
		
		[Tooltip("The former Sprite of the UGui component.")]
		public Sprite oldSprite;
		
		
		
		[Tooltip("Reset when exiting this state.")]
		public bool resetOnExit;

		public bool everyFrame;
	
		[Tooltip("Bypass button to drive the action by bool")]
		public FsmBool doThisAction = true;

		private uUI.Image _image;
		

		public override void Reset()
		{
			spriteToSwap = null;
			oldSprite = null;
			resetOnExit = false;
			everyFrame = false;
			doThisAction = true;
		}
		
		public override void OnEnter()
		{
	
			if (doThisAction.Value == false)
			{
				Finish();
			}
			else
			{
				GameObject _go = Fsm.GetOwnerDefaultTarget(gameObject);
				if (_go!=null)
				{
					_image = _go.GetComponent<uUI.Image>();
				}
				DoGetOldSprite();
	
				DoSetSprite();
				
				if (!everyFrame)
					Finish();
			}
			
		}
		
		
		public override void OnUpdate()
		{
			DoSetSprite();
		}
		
		
		
		public override void OnExit()
		{
			if (doThisAction.Value)
			{
				if (resetOnExit)
				{
					DoSetOldSprite();
				}
			}
		
		}
		

		
		void DoSetSprite()
		{
			
			
			if (_image!=null)
			{
				_image.sprite = spriteToSwap;
			}
		}
		
		void DoGetOldSprite()
		{
			
			if (_image!=null)
			{
			oldSprite = _image.sprite;
			}
		}
		
		void DoSetOldSprite()
		{
			if (_image!=null)
			{
				_image.sprite = oldSprite;
			}
		}
	
	}
}