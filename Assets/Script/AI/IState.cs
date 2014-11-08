using UnityEngine;
using System.Collections;

public interface IState 
{
	

	string name
	{
		get;
	}

	/// <summary>
	/// 当新的状态进入
	/// </summary>
	void OnEnter();

	/// <summary>
	/// 停留在当前状态
	/// </summary>
	void OnUpdate();

	/// <summary>
	/// 退出当前状态
	/// </summary>
	void OnExit();


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
