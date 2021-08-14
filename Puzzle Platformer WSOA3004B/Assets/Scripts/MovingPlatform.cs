using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] Waypoints;
    private int currentIndex;

    [SerializeField] private float platformSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        //Move platform towards target waypoint
        if (collision.gameObject.CompareTag("Player") && Vector2.Distance(Waypoints[currentIndex].transform.position, transform.position) < 0.1f)
        {
            currentIndex++;
            if (currentIndex >= Waypoints.Length)
            {
                currentIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, Waypoints[currentIndex].transform.position, platformSpeed * Time.deltaTime);
    }
}
