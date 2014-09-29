using UnityEngine;
using System.Collections;

public class AniController : BaseObject 
{
    private BasePerson person;
    private Animation ani;
    static public AniController instance;

    public AnimationData aniData;

    void Start() 
    {
        person.PersonObj = this.gameObject;
        ani = gameObject.GetComponent<Animation>();
        aniData = new AnimationData(ani);
    }

    public void SetAniData(string name,float speed,WrapMode wm)
    {
        if (string.IsNullOrEmpty(name)) { aniData.animationName = name; }
        if (speed >= 0) { aniData.speed = speed; }
        if (wm != null) { aniData.wrapMode = wm; }
    }
}

[SerializeField]
public class AnimationData 
{
    private Animation mAni;
    private string name = StateName.Idle;

    public string animationName;
    public float speed = 1.0f;
    public WrapMode wrapMode = WrapMode.Once;

    public delegate AnimationEvent OnAnimationEnded();
    public OnAnimationEnded onAnimationEnded;

    public AnimationData(Animation ani) 
    {
        this.mAni = ani;
    }

    public void Play() 
    {
        if(animationName == name)
        {
            return;
        }
        name = animationName;
        mAni.CrossFade(name);
        mAni[name].speed = speed;
        mAni.wrapMode = wrapMode;
        if(mAni.IsPlaying(name))
        {
            if (mAni[name].normalizedTime >= 0.99f) 
            {
                if(onAnimationEnded !=null)
                {
                    onAnimationEnded();
                }
            }
        }
    }


}
