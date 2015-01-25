using UnityEngine;
using System.Collections;

public class BasePerson :BaseObject {

	public Transform trans;
	public AnimCom aniCom;



	protected GameObject personObject;
	protected FSM fsm;

    public GameObject PersonObj 
    {
        get {
            if (personObject != null)
            {
                return personObject;
            }
            else 
            {
                return this.gameObject;
            }
        }
        set 
            {
                personObject = value;
            }
     }

    public BasePerson() { }


    

}
