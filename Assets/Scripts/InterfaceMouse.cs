using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceMouse : MonoBehaviour
{
    public float speed = 0.01f;


    float x2;
    //float x1;

    // Start is called before the first frame update
    void Start()
    {
        //x1 = transform.position.x;
        x2 = -transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < x2)
        {
            transform.Translate(speed, 0f, 0f);
        }


    }
}
