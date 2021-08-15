using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlatform : MonoBehaviour
{
    public ColourSwitch CS;
    public string CurrentColour;
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
        if(Collided_Gameobject.CompareTag("White"))
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255,255,255);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
        if(Collided_Gameobject.CompareTag("Red"))
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255,0,0);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
        if(Collided_Gameobject.CompareTag("Green"))
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0,255,0);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
        if(Collided_Gameobject.CompareTag("Blue"))
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0,0,255);
            CurrentColour = CS.Colour[CS.ColourCounter];
        }
    }
}
