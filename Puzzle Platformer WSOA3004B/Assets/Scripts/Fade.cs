using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public Color Color_Start;
    public Color Color_End;
    public float duration = 3f;
    Color lerpedColor = Color.white;

    float t = 0;
    bool Check;
    bool once;

    

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
        }
    }    

}
