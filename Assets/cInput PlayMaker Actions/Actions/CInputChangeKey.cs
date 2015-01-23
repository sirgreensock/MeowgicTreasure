using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("cInput will wait for a user to press a button, then bind that button to this key.")]
    public class CInputChangeKey : FsmStateAction 
    {
		[RequiredField]
		[Tooltip("The cInput key name.")]
		public FsmString action;

		[RequiredField]
		[Tooltip("Which input to change. 1 for primary (default). 2 for secondary")]
		public FsmInt input;

		[RequiredField]
		[Tooltip("Allow the input to be bound to mouse axis.")]
		public FsmBool allowMouseAxis;

		[RequiredField]
		[Tooltip("Allow the input to be bound to mouse buttons.")]
		public FsmBool allowMouseButtons;

		[RequiredField]
		[Tooltip("Allow the input to be bound to gamepad axis.")]
		public FsmBool allowGamepadAxis;

		[RequiredField]
		[Tooltip("Allow the input to be bound to gamepad buttons.")]
		public FsmBool allowGamepadButtons;

		[RequiredField]
		[Tooltip("Allow the input to be bound to keyboard.")]
		public FsmBool allowKeyboard;

		public override void Reset()
		{
			action = "";
			input = 1;
			allowMouseAxis = false;
			allowMouseButtons = false;
			allowGamepadAxis = false;
			allowGamepadButtons = true;
			allowKeyboard = true;
		}

    	// Use this for initialization
    	public override void OnEnter () 
        {
            cInput.ChangeKey(action.Value,
			                 input.Value,
			                 allowMouseAxis.Value,
			                 allowMouseButtons.Value,
			                 allowGamepadAxis.Value,
			                 allowGamepadButtons.Value,
			                 allowKeyboard.Value);
            Finish();
    	}
    }
}