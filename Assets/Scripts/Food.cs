using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject food1, food2, food3;
    public float y1, y2, y3;
    public GameObject ButtonFood;
    bool fell = true;
    int n1, n2, n3;
    int count = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        fall(food1, 2, y1);
        fall(food2, 1, y2);
        fall(food3, 0, y3);
    }

    void fall(GameObject food, int n, float y)
    {
        if (count == n)
        {
            if (food.transform.position.y > y)
                food.transform.Translate(0f, -0.1f, 0f);
            else
                fell = true;
        }
    }

    public void MyButton()
    {
        if (fell)
        {
            if (count > 1)
            {
                fell = false;
                --count;
            }
            else if (count == 1)
            {
                --count;
                ButtonFood.SetActive(false);
            }
        }
    }
}
