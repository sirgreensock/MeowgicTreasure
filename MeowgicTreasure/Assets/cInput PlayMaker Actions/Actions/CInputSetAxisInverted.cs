using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("Sets inverted property of cInput axis.")]
    public class CInputSetAxisInverted : FsmStateAction 
    {
        [RequiredField]
        [Tooltip("The cInput string name of the axis to be set.")]
        public FsmString axisName;

        [RequiredField]
        [Tooltip("Bool to set inverted status of axis.")]
        public FsmBool inverted;

    	// Use this for initialization
    	public override void OnEnter () 
        {
            cInput.AxisInverted(axisName.Value, inverted.Value);
            Finish();
    	}
    }
}