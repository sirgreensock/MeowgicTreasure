using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
	[Tooltip("Gets the pressed state of a cInput Key.")]
    public class CInputGetKey : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The cInput key name.")]
		public FsmString keyName;
		
        [Tooltip("Event to fire if key is down.")]
		public FsmEvent downEvent;
        [Tooltip("Event to fire if key is up.")]
		public FsmEvent upEvent;
		
		[UIHint(UIHint.Variable)]
		[Tooltip("Store if the key is down (True) or up (False).")]
		public FsmBool storeResult;
		
		[Tooltip("Repeat every frame. Useful if you're waiting for a key press/release.")]
		public bool everyFrame;
		
		public override void Reset()
		{
			keyName = "";
			storeResult = null;
			everyFrame = false;
		}
		
		public override void OnEnter()
		{
            ProcessAction();
			
			if (!everyFrame)
			{
				Finish();
			}
		}
		

		public override void OnUpdate()
		{
            ProcessAction();
		}
		
	    public void ProcessAction()
        {
            bool keyDown = cInput.GetKey(keyName.Value);
            storeResult.Value = keyDown;
            
            if (keyDown)
                Fsm.Event(downEvent);
            else
                Fsm.Event(upEvent); 
        }
		
	}
}