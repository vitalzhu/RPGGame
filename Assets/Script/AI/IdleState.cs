using UnityEngine;
using System.Collections;

public class IdleState : State 
{
	public IdleState()
	{
		this.name = StateName.Idle;
	}

    public override void OnStateEnter()
    {
        base.OnStateEnter();
    }

    public override void OnStateStay()
    {
        base.OnStateStay();
    }
    public override void OnStateExit()
    {
        base.OnStateExit();
    }
}
