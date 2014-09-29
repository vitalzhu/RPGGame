using UnityEngine;
using System.Collections;

public class BasePerson :BaseObject {

    private GameObject personObject;

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
