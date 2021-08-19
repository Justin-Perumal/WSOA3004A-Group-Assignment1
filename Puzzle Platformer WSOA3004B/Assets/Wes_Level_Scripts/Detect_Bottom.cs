using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Bottom : MonoBehaviour
{
    public GameObject Detect_Object;

    public GameObject Door;
    public GameObject Gamemanager;


    private void Start()
    {
        if(Gamemanager == null || Door == null)
        {
            return;
        }
    }
    private void OnTriggerEnter2D(Collider2D Collided_Gameobject)
    {
/*        string Object_name = Detect_Object.name + "(Clone)";

        if (Collided_Gameobject.name == Object_name)
        {
            Collided_Gameobject.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            Collided_Gameobject.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Collided_Gameobject.transform.position = gameObject.transform.position;
            Collided_Gameobject.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            //Gamemanager.SendMessage("addOne");
        }
        else
        {
            //Destroy(Collided_Gameobject.gameObject);
        } */

        //slight changes to make it work if they aren't clones

        if((Collided_Gameobject.tag == "Red_Object" && gameObject.tag == "Red_Detector") || (Collided_Gameobject.tag == "Green_Object" && gameObject.tag == "Green_Detector") || (Collided_Gameobject.tag == "Blue_Object" && gameObject.tag == "Blue_Detector"))
        {
            Debug.Log("Object in");
            Collided_Gameobject.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            Collided_Gameobject.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            Collided_Gameobject.transform.position = gameObject.transform.position;
            Collided_Gameobject.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;

            if(Door != null)
            {
                Door.SetActive(false);
            }

            if(Gamemanager != null)
            {
                Gamemanager.SendMessage("addOne");
            }
        }
        else
        {
            if(Collided_Gameobject.name != "Player")
            {
                Debug.Log("DDestroy Object");
                Destroy(Collided_Gameobject.gameObject);
            }
        }
    }

}
