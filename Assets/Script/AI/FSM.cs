using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FSM
{

	protected IState curState;			//当前状态，状态切换将依赖于当前状态
	protected IState lastState;			//上一次状态

	#region PUBLIC_PROPERTY
	/// <summary>
	/// 当前状态
	/// </summary>
	/// <value>The state of the current.</value>
	public IState CurrentState
	{
		get{return curState;}
	}

	public IState LastState
	{
		get{return lastState;}
	}
	#endregion PUBLIC_PROPERTY
	/// <summary>
	/// 用于注册的状态列表
	/// </summary>
	public Dictionary<string,IState> stateList = new Dictionary<string, IState>(); 

	/// <summary>
	/// 添加状态
	/// </summary>
	public virtual void RegistState(string stateName,IState state)
	{
		stateList.Add (stateName,state);
	}

	/// <summary>
	/// 切换状态
	/// </summary>
	/// <param name="newState">New state.</param>
	public virtual void SetState(IState newState)
	{
		if(curState != newState)
		{
			lastState = curState;
			curState = newState;
		}
	}

	public void AddState(IState state)
	{
		RemoveState (state);
		stateList.Add (state.name,state);
	}

	public void RemoveState(IState state)
	{
		if (stateList.ContainsKey (state.name)) 
		{
			stateList.Remove(state.name);
		}
	}

	public void OnUpdate()
	{
		if(curState!=null)
		{
			curState.OnUpdate();
		}
	}
}
