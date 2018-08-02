using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScroller : MonoBehaviour {

    int length = 4;
    int moveSpeed = 12;
    float rightPoint;
    float leftPoint;
    Renderer r;

	// Use this for initialization
	void Start ()
    {
        moveSpeed = moveSpeed * -1;
        r = GetComponent<Renderer>();
        Debug.Log(r.bounds.size.x);


        rightPoint = r.bounds.size.x * length;
        leftPoint = r.bounds.size.x * -(length - 1);
    }
	
	// Update is called once per frame
	void Update ()
    {

        //move the unit
        transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);


        // set the unit to the left point
        if(transform.position.x < leftPoint)
        {

            transform.position = new Vector3(rightPoint, transform.position.y, transform.position.z);

        }

	}
}
