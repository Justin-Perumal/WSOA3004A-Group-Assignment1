using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOutPlatforms : MonoBehaviour
{
    public float DelayTimer;
    private BoxCollider2D Box;
    private GameObject Platform;

    public bool PlatformActive;
    private float GradientTimer = 3f;
    private float GradientDelay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delay());
        Platform = gameObject;
        Box = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlatformActive)
        {
            if(GradientDelay <= GradientTimer)
            {
                GradientDelay += Time.deltaTime;
                if(GradientDelay > 1f && GradientDelay < 2f)
                {
                    Platform.GetComponent<SpriteRenderer>().color = new Color(0.294f,0.294f,0.294f);
                    //Debug.Log("First fade");
                }
                if(GradientDelay > 2f)
                {
                    Platform.GetComponent<SpriteRenderer>().color = new Color(0.588f,0.588f,0.588f);
                    //Debug.Log("Second fade");
                }
            } 
        }
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(DelayTimer);
        StartCoroutine(SwitchOff());
    }

    private IEnumerator SwitchOn()
    {
        //Debug.Log("On");
        Box.enabled = true;
        Platform.GetComponent<SpriteRenderer>().enabled = true;
        Platform.GetComponent<SpriteRenderer>().color = new Color(0f,0f,0f);
        GradientDelay = 0;
        PlatformActive = true;

        yield return new WaitForSeconds(3f);
        StartCoroutine(SwitchOff());
    }

    private IEnumerator SwitchOff()
    {
        //Debug.Log("Off");
        Box.enabled = false;
        PlatformActive = false;
        Platform.GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(3f);
        StartCoroutine(SwitchOn());

    }
}
