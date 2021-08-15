using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCheck : MonoBehaviour
{
    //public GameObject[] PlatformSequence;
    public GameObject[] Platforms;

    public bool[] CorrectPlatform;

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

        Collectible.GetComponent<BoxCollider2D>().enabled = false;
        Collectible.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckSequence();

        if(CorrectSequence)
        {
            Collectible.GetComponent<BoxCollider2D>().enabled = true;
            Collectible.GetComponent<SpriteRenderer>().enabled = true;
        }
    }

    public void CheckSequence()
    {
        if(!CorrectSequence)
        {
            if(Platforms[0].GetComponent<SpriteRenderer>().color == Green)
            {
                CorrectPlatform[0] = true;
            }
            else CorrectPlatform[0] = false;

            if(Platforms[1].GetComponent<SpriteRenderer>().color == Blue && CorrectPlatform[0])
            {
                CorrectPlatform[1] = true;
            }
            else CorrectPlatform[1] = false;

            if(Platforms[2].GetComponent<SpriteRenderer>().color == White && CorrectPlatform[0] && CorrectPlatform[1])
            {
                CorrectPlatform[2] = true;
            }
            else CorrectPlatform[2] = false;

            if(Platforms[3].GetComponent<SpriteRenderer>().color == Red && CorrectPlatform[0] && CorrectPlatform[1] && CorrectPlatform[2])
            {
                CorrectPlatform[3] = true;
            }
            else CorrectPlatform[3] = false;

            if(Platforms[4].GetComponent<SpriteRenderer>().color == Green && CorrectPlatform[0] && CorrectPlatform[1] && CorrectPlatform[2] && CorrectPlatform[3])
            {
                CorrectPlatform[4] = true;
            }
            else CorrectPlatform[4] = false;

            if(Platforms[5].GetComponent<SpriteRenderer>().color == Blue && CorrectPlatform[0] && CorrectPlatform[1] && CorrectPlatform[2] && CorrectPlatform[3] && CorrectPlatform[4])
            {
                CorrectPlatform[5] = true;
            }
            else CorrectPlatform[5] = false;

            if(Platforms[6].GetComponent<SpriteRenderer>().color == White && CorrectPlatform[0] && CorrectPlatform[1] && CorrectPlatform[2] && CorrectPlatform[3] && CorrectPlatform[4] && CorrectPlatform[5])
            {
                CorrectPlatform[6] = true;
            }
            else CorrectPlatform[6] = false;

            if(Platforms[7].GetComponent<SpriteRenderer>().color == Red && CorrectPlatform[0] && CorrectPlatform[1] && CorrectPlatform[2] && CorrectPlatform[3] && CorrectPlatform[4] && CorrectPlatform[5] && CorrectPlatform[6])
            {
                CorrectPlatform[7] = true;
            }
            else CorrectPlatform[7] = false;
        }

        if(CorrectPlatform[0] && CorrectPlatform[1] && CorrectPlatform[2] && CorrectPlatform[3] && CorrectPlatform[4] && CorrectPlatform[5] && CorrectPlatform[6] && CorrectPlatform[7])
        {
            CorrectSequence = true;
        }
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
