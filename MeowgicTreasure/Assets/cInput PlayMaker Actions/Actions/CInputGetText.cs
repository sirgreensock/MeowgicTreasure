using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("cInput 2")]
    [Tooltip("Returns text of the key used for the action. Useful for creating GUIs to change controls.")]
    public class CInputGetText : FsmStateAction 
    {
        [RequiredField]
        [Tooltip("Name of the cInput action to get text for.")]
        FsmString actionName;

        [UIHint(UIHint.Variable)]
        FsmString storeResult;

        bool everyFrame = true;

    	// Use this for initialization
    	public override void OnEnter () 
        {
            ProcessAction();
            if(!everyFrame)
            {
                Finish();
            }
    	}

        public override void OnUpdate()
        {
            ProcessAction();
        }

        public void ProcessAction()
        {
            storeResult.Value = cInput.GetText(actionName.Value);
        }
    }
}