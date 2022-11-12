using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolkVlieg : MonoBehaviour
{
    public int MoveSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
        if (transform.position.x >= 50)
        {
            Destroy(gameObject);
        }
    }
}
