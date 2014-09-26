using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSM
{

	protected State curState;			//当前状态，状态切换将依赖于当前状态
	protected State lastState;			//上一次状态

	#region PUBLIC_PROPERTY
	/// <summary>
	/// 当前状态
	/// </summary>
	/// <value>The state of the current.</value>
	public State CurrentState
	{
		get{return curState;}
	}

	public State LastState
	{
		get{return lastState;}
	}
	#endregion PUBLIC_PROPERTY
	/// <summary>
	/// 用于注册的状态列表
	/// </summary>
	public Dictionary<string,State> stateList = new Dictionary<string, State>(); 

	/// <summary>
	/// 添加状态
	/// </summary>
	public virtual void RegistState(string stateName,State state)
	{
		stateList.Add (stateName,state);
	}

	/// <summary>
	/// 切换状态
	/// </summary>
	/// <param name="newState">New state.</param>
	public virtual void SetState(State newState)
	{
		if(curState != newState)
		{
			lastState = curState;
			curState = newState;
		}
	}

	public void AddState(State state)
	{
		RemoveState (state);
		stateList.Add (state.Name,state);
	}

	public void RemoveState(State state)
	{
		if (stateList.ContainsKey (state.Name)) 
		{
			stateList.Remove(state.Name);
		}
	}

	public void OnUpdate()
	{
		if(curState!=null)
		{
			curState.OnStateStay();
		}
	}
}
