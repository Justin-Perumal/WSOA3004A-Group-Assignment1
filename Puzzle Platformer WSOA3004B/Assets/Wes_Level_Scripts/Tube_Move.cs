using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube_Move : MonoBehaviour
{
    public float speed;
    public float Min_pos;
    public float Max_pos;

    public bool left = true;
    void Update()
    {
        float Curr_pos = gameObject.transform.position.x;
        if (Curr_pos <= Min_pos)
        {
            left = false;
        }
        if (Curr_pos >= Max_pos)
        {
            left = true;
        }

        if (left)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (!left)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

    }
}
