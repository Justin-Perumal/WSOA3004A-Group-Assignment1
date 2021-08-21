using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Troll : MonoBehaviour
{
    public GameObject TrollMessage;
    public Sprite TrollFace;
    public GameObject FakeKey;
    void OnTriggerEnter2D(Collider2D Col)
    {
        TrollMessage.SetActive(true);
        FakeKey.GetComponent<SpriteRenderer>().sprite = TrollFace;
    }
}
