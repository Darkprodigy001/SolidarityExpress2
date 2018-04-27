using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn: MonoBehaviour
{

    Renderer r;

    // Use this for initialization
    void Start()
    {
        r = GetComponent<Renderer>();
        FromBlack();
    }

    //// Update is called once per frame
    //void Update()
    //{

    //    if (Input.GetKeyDown(KeyCode.Q))
    //    {
    //        StartCoroutine("ToBlack");

    //    }

    //    if (Input.GetKeyDown(KeyCode.W))
    //    {
    //        StartCoroutine("FromBlack");

    //    }

    //}

    public void FromBlack()
    {
        StartCoroutine("FadeFromBlack");
    }

    IEnumerator FadeFromBlack()
        {
            for (float f = 1f; f >= 0; f -= 0.01f)
            {
                Color c = r.material.color;
                c.a = f;
                r.material.color = c;
                yield return null;
            }
        }



        public void ToBlack()
        {
            StartCoroutine("FadeInScreen");
        }



        IEnumerator FadeInScreen()
    {
        for (float f = 0f; f <= 1; f += 0.01f)
        {
            Color c = r.material.color;
            c.a = f;
            r.material.color = c;
            yield return null;
        }
    }
}