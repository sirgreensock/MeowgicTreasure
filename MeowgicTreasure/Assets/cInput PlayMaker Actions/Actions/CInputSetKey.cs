using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
    [Tooltip("Defines the default primary input (keyboard button or gamepad/mouse axis) and optionally the secondary input to the keymap. Also optionally assigns modifier keys. Runs once. Run at beginning of game.")]
    public class CInputSetKey : FsmStateAction
	{
        [RequiredField]
        [Tooltip("The cInput action name.")]
		public FsmString action;

        [RequiredField]
        [Tooltip("Primary key.")]
        public CInputKeys primaryKey;

        [Tooltip("Secondary key. Useful for having both keyboard and gamepad support.")]
        public CInputKeys secondaryKey;

        [Tooltip("Primary modifier.")]
        public CInputKeys primaryModifier;

        [Tooltip("Secondary modifier.")]
        public CInputKeys secondaryModifier;

		public override void Reset()
		{
            action = null;
            primaryKey = CInputKeys.None;
            secondaryKey = CInputKeys.None;
            primaryModifier = CInputKeys.None;
            secondaryModifier = CInputKeys.None;
		}
		
		public override void OnEnter()
		{
            cInput.SetKey(action.Value,
                          CInputKeysUtil.GetStringForKey(primaryKey), 
                          CInputKeysUtil.GetStringForKey(secondaryKey), 
                          CInputKeysUtil.GetStringForKey(primaryModifier), 
                          CInputKeysUtil.GetStringForKey(secondaryModifier) );

			Finish();
		
		}

	}
}