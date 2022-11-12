using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletTtl = 10;
    private Vector2 direction;
    private Rigidbody2D rigidbody;
    public float reflect = 0;
    int spelerNummer;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame


    void Update()
    {
        
        bulletTtl -= Time.deltaTime;
        if (bulletTtl <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("TileMap"))
        { 
            Destroy (gameObject);
        }
            if (collision.gameObject.name == "Tank")
            {
                GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
                Destroy(gameObject);
            }
            if (collision.gameObject.name == "Tank2")
            {
                GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
                Destroy(gameObject);
            }
        if (collision.gameObject.CompareTag("Heli"))
        {
            print("Test");
            collision.gameObject.GetComponent<Animator>().SetBool("Hit", true);
            Destroy(gameObject);
        }


        GameObject.Find("GameEngine").GetComponent<TurnEngine>().wisselBeurt();
    }


}