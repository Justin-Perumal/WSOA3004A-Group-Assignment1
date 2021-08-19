using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] Waypoints;
    private int currentIndex;

    [SerializeField] private float platformSpeed;

    //Justin additions for coloured platforms --> Variables for colour and the script to check colour
    public ColourSwitch CS;
    [SerializeField] private string CurrentColour; 
    private Color White = new Color(1f,1f,1f,1f);
    private Color Red = new Color(1f,0,0,1f);
    private Color Green = new Color(0,1f,0,1f);
    private Color Blue = new Color(0,0,1f,1f);

    // Start is called before the first frame update
    void Start()
    {
        CS = GameObject.Find("Player").GetComponent<ColourSwitch>();
    }

    // Update is called once per frame
    void Update()
    {
        //Keep track of current idext
        if(Vector2.Distance(Waypoints[currentIndex].transform.position, transform.position) < 0.1f)
        {
            currentIndex++;
            if(currentIndex >= Waypoints.Length)
            {
                currentIndex = 0;
            }
        }   

        CurrentColour = CS.ColourString;   
    }

// Just made a few additions to make it work with colour

    private void OnCollisionStay2D(Collision2D collision)
    {
        //Check the platforms colour and make sure it matches the players colour
        if(gameObject.tag == "WhiteMove" && CurrentColour == "White")
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[currentIndex].transform.position, platformSpeed * Time.deltaTime);
            collision.gameObject.transform.parent = gameObject.transform;
            //Debug.Log("white platform be moving");
        }

        if(gameObject.tag == "RedMove" && CurrentColour == "Red")
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[currentIndex].transform.position, platformSpeed * Time.deltaTime);
            //Debug.Log("red platform be moving");
        }

        if(gameObject.tag == "GreenMove" && CurrentColour == "Green")
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[currentIndex].transform.position, platformSpeed * Time.deltaTime);
            //Debug.Log("green platform be moving");
        }

        if(gameObject.tag == "BlueMove" && CurrentColour == "Blue")
        {
            transform.position = Vector2.MoveTowards(transform.position, Waypoints[currentIndex].transform.position, platformSpeed * Time.deltaTime);
            //Debug.Log("blue platform be moving");
        }
        //Move platform towards target waypoint
        if (collision.gameObject.name == "Player" && Vector2.Distance(Waypoints[currentIndex].transform.position, transform.position) < 0.1f)
        {
            currentIndex++;
            if (currentIndex >= Waypoints.Length)
            {
                currentIndex = 0;
            }
        }
//        transform.position = Vector2.MoveTowards(transform.position, Waypoints[currentIndex].transform.position, platformSpeed * Time.deltaTime);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.gameObject.transform.parent = null;
    }
}
