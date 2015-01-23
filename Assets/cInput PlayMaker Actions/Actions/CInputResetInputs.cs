using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("Resets all controls back to the defaults as defined in SetKey.")]
    public class CInputResetInputs : FsmStateAction 
    {
    	// Use this for initialization
    	public override void OnEnter () 
        {
            cInput.ResetInputs();
            Finish();
    	}
    }
}