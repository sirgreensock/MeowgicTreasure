using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("Use this to manually initialize the cInput object. Normally you won't need to use this since cInput will create the cInput object automatically, but there are some situations which might require you to manually call this method.")]
    public class CInputInit : FsmStateAction 
    {
    	// Use this for initialization
    	public override void OnEnter () 
        {
            cInput.Init();
            Finish();
    	}
    }
}