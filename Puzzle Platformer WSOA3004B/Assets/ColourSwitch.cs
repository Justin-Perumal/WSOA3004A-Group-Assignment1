using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourSwitch : MonoBehaviour
{
    public GameObject Player;

    public string[] Colour;
    public string ColourString;
    public int ColourCounter;
    // Start is called before the first frame update
    void Start()
    {
        ColourCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(ColourCounter == 0)
        {
            Player.GetComponent<SpriteRenderer>().color = new Color(255,255,255);
            ColourString = Colour[ColourCounter];
            gameObject.tag = ColourString;
        }
        else if(ColourCounter == 1)
        {
            Player.GetComponent<SpriteRenderer>().color = new Color(255,0,0);
            ColourString = Colour[ColourCounter];
            gameObject.tag = ColourString;
        }
        else if(ColourCounter == 2)
        {
            Player.GetComponent<SpriteRenderer>().color = new Color(0,255,0);
            ColourString = Colour[ColourCounter];
            gameObject.tag = ColourString;
        }
        else if(ColourCounter == 3)
        {
            Player.GetComponent<SpriteRenderer>().color = new Color(0,0,255);
            ColourString = Colour[ColourCounter];
            gameObject.tag = ColourString;
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            if(ColourCounter==3)
            {
                ColourCounter = 0;
            }
            else
            {
                ColourCounter++;
            }
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
            if(ColourCounter==0)
            {
                ColourCounter = 3;
            }
            else
            {
                ColourCounter--;
            }
        }
    }
}
