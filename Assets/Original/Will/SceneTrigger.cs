using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{

    public FadeIn f2b;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TrainFront")
        {
            Debug.Log("Calling fade to black");
            f2b.ToBlack();

        }
    }
}
