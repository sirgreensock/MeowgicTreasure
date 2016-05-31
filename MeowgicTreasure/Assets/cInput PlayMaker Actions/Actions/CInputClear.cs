using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("Clears all data stored by cInput from PlayerPrefs. This can fix problems that may occur when changing the number or order of inputs used by cInput..")]
    public class CInputClear : FsmStateAction 
    {
    	// Use this for initialization
    	public override void OnEnter () 
        {
            cInput.Clear();
            Finish();
    	}
    }
}