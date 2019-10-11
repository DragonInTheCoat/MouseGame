using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public GameObject Mouse1, Mouse2, Mouse3;
    public GameObject Food1, Food2, Food3;
    public int MaxSpeed, MinSpeed;
    public float EndField = 10;
    float rnd1, rnd2, rnd3;
    float x1, x2, x3;

    // Start is called before the first frame update
    void Start()
    {
        rnd1 = Random.Range(MaxSpeed, MinSpeed);
        rnd2 = Random.Range(MaxSpeed, MinSpeed);
        rnd3 = Random.Range(MaxSpeed, MinSpeed);
        x1 = Food1.transform.position.x;
        x2 = Food2.transform.position.x;
        x3 = Food3.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        fun(Mouse1, x1, rnd1, Food1);
        fun(Mouse2, x2, rnd2, Food2);
        fun(Mouse3, x3, rnd3, Food3);
    }

    void fun(GameObject Mouse, float x, float rnd, GameObject Food)
    {
        float mouseX = Mouse.transform.position.x;
        if (mouseX > EndField)
            Mouse.SetActive(false);
        else if (Mouse.transform.position.y < Food.transform.position.y || 
            (mouseX < x - 1 || mouseX > x))
        {
            Mouse.transform.Translate(0.01f * rnd, 0, 0);
        }
        
    }
}
