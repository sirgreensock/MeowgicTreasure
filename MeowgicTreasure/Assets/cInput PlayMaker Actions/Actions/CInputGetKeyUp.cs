using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
	[Tooltip("Sends an Event when a Key is released.")]
    public class CInputGetKeyUp : FsmStateAction
	{
        [RequiredField]
        [Tooltip("The cInput key name.")]
		public FsmString keyName;

        [Tooltip("Event to fire if key is released.")]
		public FsmEvent sendEvent;
		
        [UIHint(UIHint.Variable)]
        [Tooltip("Store true if the key was released.")]
		public FsmBool storeResult;

        [Tooltip("Repeat every frame. Useful if you're waiting for a key release.")]
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
            bool keyUp = cInput.GetKeyUp(keyName.Value);
            storeResult.Value = keyUp;
            
            if (keyUp)
                Fsm.Event(sendEvent);
        }
	}
}