using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
	[Tooltip("Gets the pressed state of a cInput Button.")]
    public class CInputGetButton : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The cInput button name.")]
		public FsmString buttonName;
		
        [Tooltip("Event to fire if button is down.")]
		public FsmEvent downEvent;
        [Tooltip("Event to fire if button is up.")]
		public FsmEvent upEvent;
		
		[UIHint(UIHint.Variable)]
		[Tooltip("Store if the button is down (True) or up (False).")]
		public FsmBool storeResult;
		
		[Tooltip("Repeat every frame. Useful if you're waiting for a button press/release.")]
		public bool everyFrame;
		
		public override void Reset()
		{
			buttonName = "";
			storeResult = null;
			everyFrame = true;
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
            bool buttonDown = cInput.GetButton(buttonName.Value);
            storeResult.Value = buttonDown;
            
            if (buttonDown)
                Fsm.Event(downEvent);
            else
                Fsm.Event(upEvent); 
        }
		
	}
}