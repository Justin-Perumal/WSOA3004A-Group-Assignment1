using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Bottom : MonoBehaviour
{
    public GameObject Detect_Object;
    public GameObject Gamemanager;

    private void OnTriggerEnter2D(Collider2D Collided_Gameobject)
    {
        string Object_name = Detect_Object.name + "(Clone)";

        if (Collided_Gameobject.name == Object_name)
        {
            Collided_Gameobject.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            Collided_Gameobject.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Collided_Gameobject.transform.position = gameObject.transform.position;
            Collided_Gameobject.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            Gamemanager.SendMessage("addOne");
        }
        else
        {
            Destroy(Collided_Gameobject.gameObject);
        }

    }

}
