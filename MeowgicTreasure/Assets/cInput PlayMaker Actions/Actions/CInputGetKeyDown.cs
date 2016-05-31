using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
	[Tooltip("Sends an Event when a cInput Key is pressed.")]
    public class CInputGetKeyDown : FsmStateAction
	{
        [RequiredField]
        [Tooltip("The cInput key name.")]
		public FsmString keyName;

        [Tooltip("Event to fire if key is pressed.")]
		public FsmEvent sendEvent;
		
        [UIHint(UIHint.Variable)]
        [Tooltip("Store true if the key was pressed.")]
		public FsmBool storeResult;

        [Tooltip("Repeat every frame. Useful if you're waiting for a key press.")]
        public bool everyFrame;

		public override void Reset()
		{
			sendEvent = null;
			keyName = null;
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
            bool keyDown = cInput.GetKeyDown(keyName.Value);
            storeResult.Value = keyDown;
            
            if (keyDown)
                Fsm.Event(sendEvent);
        }
	}
}