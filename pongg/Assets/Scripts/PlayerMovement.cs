using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int PlayerNumber = 1;
    private float movespeed = 5f;
    // Update is called once per frame
    void Update()
    {
        if (PlayerNumber == 1)
        {
            transform.Translate(new Vector2(0, Input.GetAxis("Player1") * 15 * Time.deltaTime));
        }

        if (PlayerNumber == 2)
        {
            transform.Translate(new Vector2(0, Input.GetAxis("Player2") * 15 * Time.deltaTime));
        }
        transform.position = new Vector2 (transform.position.x, Mathf.Clamp(transform.position.y,-7.5f,7.5f));
    }
}
