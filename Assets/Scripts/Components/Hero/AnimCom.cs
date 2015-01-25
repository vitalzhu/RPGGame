using UnityEngine;
using System.Collections;

public class AnimCom : MonoBehaviour {

	private Animation anim;

	public CallBack.ResposeCallBack OnKeyFrameEnter;

	void Awake()
	{
		anim = this.animation;

	}

	public void OnKeyFrameEvent(int value)
	{
		if(OnKeyFrameEnter!=null)
		{
			OnKeyFrameEnter((object)value);
		}
	}

	#region ANIMATION_BEHAVIOUR
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

	#endregion ANIMATION_BEHAVIOUR
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
