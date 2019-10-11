using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiController : MonoBehaviour
{
    public int Period = 250; //количество по 0.002
    public GameObject pi1, pi2, pi3;
    int times, count;
    // Start is called before the first frame update
    void Start()
    {
        times = Period;
        count = 3;
        pi1.SetActive(false);
        pi2.SetActive(false);
        pi3.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(times-- <= 0)
        {
            if (count-- < -2)
                count = 3;
            pi1.SetActive(count < 3 && count > -1);
            pi2.SetActive(count < 2 && count > -2);
            pi3.SetActive(count < 1 && count > -3);
            times = Period;
        }
            
    }
}
