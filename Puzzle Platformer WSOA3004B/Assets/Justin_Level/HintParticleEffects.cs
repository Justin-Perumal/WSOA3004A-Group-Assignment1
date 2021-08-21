using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintParticleEffects : MonoBehaviour
{
    public ParticleSystem[] ParticleHints;
    private bool InRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && InRange)
        {
            PlayHint();
        }
    }

    public void PlayHint()
    {
        for(int i=0; i<ParticleHints.Length; i++)
        {
            ParticleHints[i].Play();
        }
    }

    private IEnumerator Delay(int Counter)
    {
        ParticleHints[Counter].Play();
        yield return new WaitForSeconds(3f);
    }

    private void OnTriggerStay2D(Collider2D Col)
    {
        InRange = true;
    }

    private void OnTriggerExit2D(Collider2D Col)
    {
        InRange = false;
    }
}
