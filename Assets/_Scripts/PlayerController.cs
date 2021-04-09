using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range(1, 10)]
    public float velocity;

    GameManager gm;
    void Start()
    {
        gm = GameManager.GetInstance();
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        transform.position +=new Vector3(inputX, inputY, 0) * Time.deltaTime * velocity;
    }


}