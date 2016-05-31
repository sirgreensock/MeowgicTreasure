using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
    [Tooltip("Creates an axis out of two inputs, which must be previously set with the SetKey function. The first input " + 
            "will be the negative axis, the second input the positive axis. Note that if only one input is passed in " +
            "then the axis will only return positive values (unless inverted). You can optionally assign the sensitivity, " +
            "gravity, or deadzone of the axis by passing in sensitivity, gravity, and deadzonerespectively. " +
            "Additionally, you can use SetAxisSensitivity, SetAxisGravity, and SetAxisDeadzoneif you want to " +
            "change these optional values for an axis after it has already been created. " +
            "Also note that setting up axes is not required and you should only do this if you require analog-like " +
            "controls instead of digital controls. An axis input can be analog (e.g., gamepad axis) or digital (e.g., " +
            "keyboard button) or even a combination of the two. A virtual analog axis will be created if necessary. " +
            "Runs once. Run this once at the begining of your game to set axis.")]
    public class CInputSetAxis : FsmStateAction
	{
        [RequiredField]
        [Tooltip("The cInput axis name.")]
		public FsmString axisName;

        [RequiredField]
        [Tooltip("The cInput action to use for negative input on the axis.")]
		public FsmString negativeInput;

        [RequiredField]
        [Tooltip("The cInput action to use for positive input on the axis.")]
		public FsmString positiveInput;

        [RequiredField]
        [Tooltip("Axis sensitivity.")]
		public FsmFloat sensitivity;

        [RequiredField]
        [Tooltip("Axis gravity.")]
		public FsmFloat gravity;

        [RequiredField]
        [Tooltip("Axis dead zone.")]
		public FsmFloat deadZone;

        [RequiredField]
        [Tooltip("True if axis is inverted.")]
		public FsmBool invert;
		
		public override void Reset()
		{
			sensitivity = 1.0f;
			gravity = 0.0f;
			deadZone = 0.19f;
		}
		
		public override void OnEnter()
		{
			cInput.SetAxis(axisName.Value, negativeInput.Value, positiveInput.Value, sensitivity.Value, gravity.Value, deadZone.Value);
			
			if(invert.Value)
			{
				cInput.AxisInverted(axisName.Value, true);
			}
			
			Finish();
		
		}
		
		public override void OnUpdate()
		{
			
		}
	}
}