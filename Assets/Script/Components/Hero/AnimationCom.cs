using UnityEngine;
using System.Collections;

public class AnimationCom : MonoBehaviour {

	private Animation anim;

	void Awake()
	{
		anim = this.animation;

	}
	

	public void Idle()
	{
		string name = "idle";
		PlayAnimation (name,WrapMode.Loop);
	}

	public void Run()
	{
		string name = "run";
		PlayAnimation (name,WrapMode.Loop);
	}

	public void Attack01()
	{
		string name = "Attack01";
		PlayAnimation (name,WrapMode.Once);
	}

	public void Die()
	{
		string name = "Die";
		PlayAnimation (name ,WrapMode.Once);
	}

	/// <summary>
	/// 播放动画
	/// </summary>
	/// <param name="name">动画名称</param>
	/// <param name="wrapMode">循环模式.</param>
	private void PlayAnimation(string name,WrapMode wrapMode)
	{
		anim.CrossFade (name);
		anim.wrapMode = wrapMode;
	}


}
