using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour
{
    public Color ColorOne;
    public Color ColorTwo;
    public float speed = 0.1f;
    Color Current_color;
    void Start()
    {
        Current_color = ColorOne;
        StartCoroutine(colorswitch());
    }

    // Update is called once per frame
    void Update()
    {
        if (Current_color == ColorOne)
        {
            Current_color = ColorTwo;
            Debug.Log("color = 2");
        }
        else
        {
            Current_color = ColorOne;
            Debug.Log("color = 1");
        }
    }
    IEnumerator colorswitch()
    {



        return null;
    }
}
