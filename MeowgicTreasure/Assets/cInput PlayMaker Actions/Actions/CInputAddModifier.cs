using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("Sets cInput modifier. Runs once. Run this once at the begining of your game to designate a key as a modifier.")]
    public class CInputAddModifier : FsmStateAction 
    {
        [RequiredField]
        [Tooltip("The cInput string name of the key to be used as a modifier.")]
        public CInputKeys modifierInput;

    	// Use this for initialization
    	public override void OnEnter () 
        {
            cInput.AddModifier(CInputKeysUtil.GetStringForKey(modifierInput) );
            Finish();
    	}
    }
}