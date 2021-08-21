using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCheck : MonoBehaviour
{
    //public GameObject[] PlatformSequence;
    public GameObject[] Platforms;
    public string[] PlatformCorrectColours;

    public bool[] CorrectPlatform;
    public bool AllCorrect;
    public GameObject MovePoint;
    //public string[] PlatformColours;   --> For final iterations allowing for the platform sequence to be scalable and reusable

    private bool CorrectSequence;

    private Color White = new Color(255,255,255);
    private Color Red = new Color(255,0,0);
    private Color Green = new Color(0,255,0);
    private Color Blue = new Color(0,0,255);

    public GameObject Collectible;

    // Start is called before the first frame update
    void Start()
    {
        CorrectSequence = false;
        Collectible = gameObject;

        //Collectible.GetComponent<BoxCollider2D>().enabled = false;
        //Collectible.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        AllCorrect = CheckPlatforms();

        if(AllCorrect)
        {
            CorrectSequence = true;
        }
        else CorrectSequence = false;

        CheckSequence();

        if(CorrectSequence)
        {
            transform.position = Vector2.MoveTowards(transform.position, MovePoint.transform.position, 1.5f*Time.deltaTime);
            //Collectible.GetComponent<BoxCollider2D>().enabled = true;
            //Collectible.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    private void CheckSequence()
    {
        if(!CorrectSequence)
        {
            for(int i = 0; i < Platforms.Length; i++)
            {
                if(Platforms[i].GetComponent<ChangePlatform>().CurrentColour == PlatformCorrectColours[i])
                {
                    CorrectPlatform[i] = true;
                }
                else if(Platforms[i].GetComponent<ChangePlatform>().CurrentColour != PlatformCorrectColours[i])
                {
                    CorrectPlatform[i] = false;
                }
            }
        }
    }

    private bool CheckPlatforms()
    {
        for(int i = 0; i < CorrectPlatform.Length; i++)
        {
            if(CorrectPlatform[i] == false)
            {
                return false;
            }
        }

        return true;
    }

// Sequencing is not working as intended at the moment ---> will be fixed by final iteration

    public void ResetPlatform()
    {
        for(int i=0;i<Platforms.Length;i++)
        {
            Platforms[i].GetComponent<SpriteRenderer>().color = White;
        }
    }

    void OnTriggerEnter2D(Collider2D Collided_Gameobject)
    {
        Debug.Log("Collected the prize - Completed level");
    }
}
