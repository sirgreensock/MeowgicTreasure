// (c) Copyright HutongGames, LLC 2010-2014. All rights reserved.
//--- __ECO__ __ACTION__ ---//

using UnityEngine;
using uUI = UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("uGui")]
	[Tooltip("Set the properties of a uGUI Slider. Internal rounding is nearest whole(with Whole Numbers on).")]
	public class uGuiSetSliderProperties : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(uUI.Slider))]
		[Tooltip("The GameObject with the button ui component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Set the Min Value of the slider.")]
		public FsmFloat minValue;

		[Tooltip("Set the Max Value of the slider.")]
		public FsmFloat maxValue;

		[Tooltip("Toggle Whole Numbers for this slider.")]
		public FsmBool wholeNumbers;

		[UIHint(UIHint.FsmFloat)]
		[Tooltip("Set the slider current value explicitly.")]
		public FsmFloat value;

		[Tooltip("Do this every frame?")]
		public FsmBool everyFrame;

		private uUI.Slider slider;
		
		public override void Reset()
		{
			minValue = 0f;
			maxValue = 1f;
			wholeNumbers = false;
			value = null;
			everyFrame = false;
		}
		
		public override void OnEnter()
		{
			GameObject go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go!=null)
			{
				slider = go.GetComponent<uUI.Slider>();
			}

			DoValues();

			if (!everyFrame.Value)
			{
				Finish();
			}
		}
		
		public override void OnUpdate()
		{
			DoValues();
		}

		void DoValues()
		{
			if (!minValue.IsNone)
			{
				slider.minValue = minValue.Value;
			}

			if (!maxValue.IsNone)
			{
				slider.maxValue = maxValue.Value;
			}

			if (!wholeNumbers.IsNone)
			{
				slider.wholeNumbers = wholeNumbers.Value;
			}

			if (!value.IsNone)
			{
				slider.value = value.Value;
			}
		}
	}
}