using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("cInput 2")]
	[Tooltip("Get cInput axis value.")]
	public class CInputGetAxis : FsmStateAction 
	{
		[RequiredField]
		[Tooltip("The cInput axis name.")]
		public FsmString axisName;
		
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the value of the axis (-1 to 1).")]
		public FsmFloat storeResult;
		
        [Tooltip("Sensitivity for positive/negative Event")]
        public FsmFloat axisSensitivity;

		[Tooltip("Event sent if axis is less than sensitivity and greater than negative sensitivity.")]
		public FsmEvent zeroEvent;
		[Tooltip("Event sent if axis is greater than sensitivity.")]
		public FsmEvent positiveEvent;
		[Tooltip("Event sent if axis is less than negative sensitivity")]
		public FsmEvent negativeEvent;
		

		[Tooltip("Repeat every frame. Useful for continous input.")]
		public bool everyFrame;
		
		public override void Reset()
		{
			axisName = "";
			storeResult = null;
			everyFrame = false;
		}
		
		public override void OnEnter()
		{
            ProcessAction();
			
			if (!everyFrame)
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
            float axisValue = cInput.GetAxis(axisName.Value);
            storeResult.Value = axisValue;
            
            if(axisValue > axisSensitivity.Value)
            {
                Fsm.Event(positiveEvent);
            }
            else if(axisValue < -axisSensitivity.Value)
            {
                Fsm.Event(negativeEvent);
            }
            else
            {
                Fsm.Event(zeroEvent);
            }   
        }
		
	}
}