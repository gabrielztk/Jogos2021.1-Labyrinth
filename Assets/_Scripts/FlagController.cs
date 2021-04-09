using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagController : MonoBehaviour
{
    GameManager gm;
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
            }
        }
    }
}
