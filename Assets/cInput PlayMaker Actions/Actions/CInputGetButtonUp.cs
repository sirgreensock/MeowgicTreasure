using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
	[Tooltip("Sends an Event when a Key is released.")]
    public class CInputGetButtonUp : FsmStateAction
	{
        [RequiredField]
        [Tooltip("The cInput button name.")]
		public FsmString buttonName;

        [Tooltip("Event to fire if button is released.")]
		public FsmEvent sendEvent;
		
        [UIHint(UIHint.Variable)]
        [Tooltip("Store true if the button was released.")]
		public FsmBool storeResult;

        [Tooltip("Repeat every frame. Useful if you're waiting for a button release.")]
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
            bool buttonUp = cInput.GetButtonUp(buttonName.Value);
            storeResult.Value = buttonUp;
            
            if (buttonUp)
                Fsm.Event(sendEvent);
        }
	}
}