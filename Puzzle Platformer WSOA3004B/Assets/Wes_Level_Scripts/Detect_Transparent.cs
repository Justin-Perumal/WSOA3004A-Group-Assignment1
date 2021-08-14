using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Transparent : MonoBehaviour
{
    public float seconds;
    public GameObject Detect_Object;
    
    private void OnTriggerEnter2D(Collider2D Collided_Gameobject)
    {
        if (Collided_Gameobject.name== "Blue_object(Clone)")
        {
            Collided_Gameobject.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(Turnon_Collider());
            Collided_Gameobject.transform.position = gameObject.transform.position;
            Collided_Gameobject.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        IEnumerator Turnon_Collider()
        {
            yield return new WaitForSeconds(seconds);
            Collided_Gameobject.gameObject.GetComponent<BoxCollider2D>().enabled = true;
            
        }
    }
    
    
}
