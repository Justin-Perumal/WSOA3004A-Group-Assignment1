using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Spawn : MonoBehaviour
{
    public float Depression;
    public GameObject Spawn_Object;
    public GameObject Tube;
    Vector3 Curr_Pos;

    private void Start()
    {
        Curr_Pos = gameObject.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            gameObject.transform.Translate(Vector2.left * Depression * Time.deltaTime);
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            StartCoroutine(Button_Pressed());
            SpawnColor();
        }
        IEnumerator Button_Pressed()
        {
            yield return new WaitForSeconds(2);
            gameObject.transform.position = Curr_Pos;
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }

    void SpawnColor()
    {
       //Instantiate(Spawn_Object, new Vector2 (Tube.transform.position.x, Tube.transform.position.y-.5f), Quaternion.identity);
       if(Spawn_Object.GetComponent<BoxCollider2D>().enabled == true)
       {
            Spawn_Object.transform.position = Tube.transform.position;
       }
    }

    
}
