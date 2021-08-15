using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public int num = 0;
    public GameObject Triangle;
    public void Update()
    {
        if (num >= 6)
        {
            Triangle.gameObject.SetActive(true);
        }
        if (num<6)
        {
            Triangle.gameObject.SetActive(false);

        }
    }
    public void addOne()
    {
        num++;
    }


}
