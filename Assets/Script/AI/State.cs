using UnityEngine;
using System.Collections;

public class State 
{

	protected string name;

	public string Name
	{
		get{return name;}
		/*
		set{
			if(value !=null)
			{
				name = value;
			}
		}*/
	}

	/// <summary>
	/// 当新的状态进入
	/// </summary>
	public virtual void OnStateEnter()
	{

	}

	/// <summary>
	/// 停留在当前状态
	/// </summary>
	public virtual void OnStateStay()
	{

	}

	/// <summary>
	/// 退出当前状态
	/// </summary>
	public virtual void OnStateExit()
	{

	}



}

public class StateName
{
	public static string Idle = "Idle";
	public static string Run = "Run";
	public static string Walk = "Walk";
	public static string Damage = "Damage";
	public static string Dead = "Dead";
	public static string Attack = "Attack";
	public static string ComboAttack = "ComboAttack";
	public static string Skill = "Skill";
}
