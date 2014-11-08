using UnityEngine;
using System.Collections;

public class IdleState : IState 
{
	public string name
	{
		get 
		{
			return StateType.Idle.ToString();
		}
	}

	public IdleState()
	{

	}

	public void OnEnter()
	{

	}

	public void OnUpdate(){}

	public void OnExit(){}
}
