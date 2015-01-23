using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("Toggles cInput default GUI")]
    public class CInputToggleGUI : FsmStateAction 
    {
    	// Use this for initialization
    	public override void OnEnter () 
        {
            cGUI.ToggleGUI();
            Finish();
    	}
    }
}