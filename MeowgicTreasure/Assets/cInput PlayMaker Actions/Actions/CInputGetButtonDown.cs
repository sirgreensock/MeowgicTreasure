using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
	[Tooltip("Sends an Event when a cInput Key is pressed.")]
    public class CInputGetButtonDown : FsmStateAction
	{
        [RequiredField]
        [Tooltip("The cInput button name.")]
		public FsmString buttonName;

        [Tooltip("Event to fire if button is pressed.")]
		public FsmEvent sendEvent;
		
        [UIHint(UIHint.Variable)]
        [Tooltip("Store true if the button was pressed.")]
		public FsmBool storeResult;

        [Tooltip("Repeat every frame. Useful if you're waiting for a button press.")]
        public bool everyFrame;

		public override void Reset()
		{
			sendEvent = null;
			buttonName = null;
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
            bool buttonDown = cInput.GetButtonDown(buttonName.Value);
            storeResult.Value = buttonDown;
            
            if (buttonDown)
                Fsm.Event(sendEvent);
        }
	}
}