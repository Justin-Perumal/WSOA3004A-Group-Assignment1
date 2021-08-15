using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_delete : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Falling_Object")
        {
            Destroy(collision.gameObject);
        }
    }
}
