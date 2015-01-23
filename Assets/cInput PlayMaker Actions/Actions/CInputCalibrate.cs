using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("This calibrates analog inputs to their default/neutral position.")]
    public class CInputCalibrate : FsmStateAction 
    {
    	// Use this for initialization
    	public override void OnEnter () 
        {
            cInput.Calibrate();
            Finish();
    	}
    }
}