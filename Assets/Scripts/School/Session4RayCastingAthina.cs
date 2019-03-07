using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4RayCastingAthina : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 raycastingDirection = transform.forward;
        RaycastHit objInFront;

        if(Physics.Raycast(transform.position, raycastingDirection, out objInFront))
        {
            Debug.Log(objInFront.transform.name);
            if (objInFront.transform.GetComponent<ListenScript>() != null)
            {
                objInFront.transform.GetComponent<ListenScript>().seen = true;
            }
           
                
        }

	}
}
