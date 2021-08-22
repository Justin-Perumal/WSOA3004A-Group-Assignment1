using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    Color Color_Start;
    Color Color_End;
    public float duration = 3f;
    Color lerpedColor = Color.white;

    float t = 0;
    bool Check;

    public Color[] Color_array;
    
    // Use this for initialization
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        lerpedColor = Color.Lerp(Color_Start, Color_End, t);
        gameObject.GetComponent<Camera>().backgroundColor= lerpedColor;

        if (Check == true)
        {
            t -= Time.deltaTime / duration;
            if (t < 0.01f)
                Check = false;
        }
        else
        {
            t += Time.deltaTime / duration;
            if (t > 0.99f)
                Check = true;
            Color_Changer_Random();
        }
    }

    void Color_Changer_Random()
    {
        int Random_num = Random.Range(0,Color_array.Length);
        Color_Start = Color_End;
        Color_End = Color_array[Random_num];
    }
    

}
