using UnityEngine;
using System.Collections;

public class AniController : BaseObject {


}

[SerializeField]
public class AnimationData 
{
    public string name = StateName.Idle;
    public float speed = 1.0f;
    public WrapMode wrapMode = WrapMode.Once;


}
