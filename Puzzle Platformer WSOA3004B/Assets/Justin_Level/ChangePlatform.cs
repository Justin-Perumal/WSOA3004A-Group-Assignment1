using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlatform : MonoBehaviour
{
    public ColourSwitch CS;
    public string CurrentColour;

    public BoxCollider2D PlatformCollider;
    // Start is called before the first frame update
    void Start()
    {
        CS = GameObject.Find("Player").GetComponent<ColourSwitch>();
        PlatformCollider.enabled = false;
        PlatformCollider.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Collided_Gameobject)
    {
        if((Collided_Gameobject.CompareTag("White") && CurrentColour == "White"))
        {
            Debug.Log("White col disabled");
            PlatformCollider.enabled = false;
        }

        if((Collided_Gameobject.CompareTag("Red")) && CurrentColour == "Red")
        {
            Debug.Log("Red col disabled");
            PlatformCollider.enabled = false;
        }

        if(Collided_Gameobject.CompareTag("Blue") && CurrentColour == "Blue")
        {
            Debug.Log("Blue col disabled");
            PlatformCollider.enabled = false;
        }

        if(Collided_Gameobject.CompareTag("Green") && CurrentColour == "Green")
        {
            Debug.Log("Green col disabled");
            PlatformCollider.enabled = false;
        }

        if(Collided_Gameobject.CompareTag("Green_Object") && CurrentColour != "Green")
        {
            PlatformCollider.enabled = false;
        }

        if(Collided_Gameobject.CompareTag("Red_Object") && CurrentColour != "Red")
        {
            PlatformCollider.enabled = false;
        }

                if(Collided_Gameobject.CompareTag("Blue_Object") && CurrentColour != "Blue")
        {
            PlatformCollider.enabled = false;
        }
    }

    void OnCollisionEnter2D(Collision2D Col)
    {
        if(Col.gameObject.tag == "White")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255,255,255);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
        if(Col.gameObject.tag =="Red")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255,0,0);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
        if(Col.gameObject.tag == "Green")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(96,200,111,255);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
        if(Col.gameObject.tag == "Blue")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(49,147,184,255);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
    }

    void OnTriggerExit2D(Collider2D Col)
    {
        PlatformCollider.enabled = true;
    }
}
