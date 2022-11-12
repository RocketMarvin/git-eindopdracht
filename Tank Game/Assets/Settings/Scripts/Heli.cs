using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heli : MonoBehaviour
{
    [SerializeField]
    float MoveSpeed;
    int direction = 0;
    float MoveHellie;
    bool flipX = false;


    // Start is called before the first frame update
    void Start()
    {
        direction = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 50)
        {
            if (direction == 0)
            {
                transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
            }
        }

        if (transform.position.x >= 49)
        {
            MoveSpeed = -4;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (transform.position.x <= -50)
        {
            MoveSpeed = 4;
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
    
}
