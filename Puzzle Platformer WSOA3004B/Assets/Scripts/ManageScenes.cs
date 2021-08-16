using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void LoadJustinLevel()
    {
        SceneManager.LoadScene("Justin_Level");
    }

    public void LoadSiyaLevel()
    {
        SceneManager.LoadScene("Siya_Level");
    }

    public void LoadWesLevel()
    {
        SceneManager.LoadScene("Wes_Level");
    }

    public void OnTriggerEnter2D(Collider2D Collider)
    {
        SceneManager.LoadScene("MainMenu");
    }
}
