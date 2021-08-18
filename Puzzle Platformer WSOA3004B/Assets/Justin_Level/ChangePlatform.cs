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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Collided_Gameobject)
    {
        if(Collided_Gameobject.CompareTag("White") && CurrentColour == "White")
        {
            PlatformCollider.enabled = false;
        }

        if(Collided_Gameobject.CompareTag("Red") && CurrentColour == "Red")
        {
            PlatformCollider.enabled = false;
        }

        if(Collided_Gameobject.CompareTag("Blue") && CurrentColour == "Blue")
        {
            PlatformCollider.enabled = false;
        }

        if(Collided_Gameobject.CompareTag("Green") && CurrentColour == "Green")
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
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0,255,0);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
        if(Col.gameObject.tag == "Blue")
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,255);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
    }

    void OnTriggerExit2D(Collider2D Col)
    {
        PlatformCollider.enabled = true;
    }
}
