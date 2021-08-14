using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourCheck : MonoBehaviour
{
    //public GameObject[] PlatformSequence;
    public GameObject Platform1;
    public GameObject Platform2;
    public GameObject Platform3;
    public GameObject Platform4;

    public bool Plat1Correct;
    public bool Plat2Correct;
    public bool Plat3Correct;
    public bool Plat4Correct;

    private Color White = new Color(255,255,255);
    private Color Red = new Color(255,0,0);
    private Color Green = new Color(0,255,0);
    private Color Blue = new Color(0,0,255);

    public GameObject Collectible;

    // Start is called before the first frame update
    void Start()
    {
        Plat1Correct = false;
        Plat2Correct = false;
        Plat3Correct = false;
        Plat4Correct = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Platform1.GetComponent<SpriteRenderer>().color == White)
        {
            Plat1Correct = true;
        }
        else Plat1Correct = false;

        if(Platform2.GetComponent<SpriteRenderer>().color == Red)
        {
            Plat2Correct = true;
        }
        else Plat2Correct = false;

        if(Platform3.GetComponent<SpriteRenderer>().color == Green)
        {
            Plat3Correct = true;
        }
        else Plat3Correct = false;

        if(Platform4.GetComponent<SpriteRenderer>().color == Blue)
        {
            Plat4Correct = true;
        }
        else Plat4Correct = false;

        if(Plat1Correct && Plat2Correct && Plat3Correct && Plat4Correct)
        {
            Debug.Log("Puzzle Completed");
        }
    }
}
