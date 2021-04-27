using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagController : MonoBehaviour
{
    GameManager gm;
    string scene_name;
    void Start()
    {
        gm = GameManager.GetInstance();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gm.gems == 0) 
            {
                Debug.Log("You Win!");
                scene_name = SceneManager.GetActiveScene().name;
                if (scene_name == "Forest")
                {
                    SceneManager.LoadScene("Canyon");
                }
                if (scene_name == "Canyon")
                {
                    SceneManager.LoadScene("MainMenu");
                }
                
            }
        }
    }
}
