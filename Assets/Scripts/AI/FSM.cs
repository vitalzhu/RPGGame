using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSM
{

	public IState curState;

	public delegate void OnChangeState(IState lastState,IState curState);
	public event OnChangeState ChangeStateEvent;



	public void ChangeState(IState state)
	{
		if(curState!=null)
		{
			curState.Exit();
		}
		if(ChangeStateEvent!=null)
		{
			ChangeStateEvent(curState,state);
		}
		if(state != null)
		{
			curState = state;
			state.Enter();
		}
	}

	public void Execute()
	{
		if(curState!=null )
		{
			curState.Execute();
		}
	}



}
