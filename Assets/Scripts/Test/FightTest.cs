using UnityEngine;
using System.Collections;

public class FightTest : MonoBehaviour {

	public enum Role
	{
		Hero,
		Monster,
		None,
	}

	#region PUBLIC_VARIABLE

	public Role roleID = Role.None;
	public GameObject roleObj;
	public float runSpeed = 1.0f;

	#endregion PUBLIC_VARIABLE

	#region PRIVATE_VARIABLE

	private Animation anima;


	#endregion PRIVATE_VARIABLE

	#region UNITY_METHODS
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	#endregion UNITY_METHODS

	#region BEHAVIOUR_METHODS

	public void Attack()
	{

	}

	#endregion BEHAVIOUR_METHODS


	#region ANIMATION

	private void Run()
	{

	}

	#endregion ANIMATION
}


public class AniName
{
	public static string Idle = "";
	public static string Attack = "";
	public static string Run = "";
}