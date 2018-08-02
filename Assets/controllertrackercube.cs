using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllertrackercube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Renderer R;
            R = GetComponent<Renderer>();

            R.material.color = Color.red;

        }
		
	}
}
