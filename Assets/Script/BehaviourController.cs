using UnityEngine;
using System.Collections;

public class BehaviourController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTiggerEnter(Collider collider)
	{
		Debug.Log ("_____Tigger");
	}

	void OnCollisionEnter(Collision c)
	{
		Debug.Log ("_____Collision = "+c.collider.gameObject.name);
	}
}
