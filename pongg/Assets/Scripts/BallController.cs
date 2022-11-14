using UnityEngine;

public class BallController : MonoBehaviour
{
    private float movespeed = 10f;
    private Vector2 direction;


    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        if (direction.x > -0.1f && direction.x < 0.1f)
        {
            direction = new Vector2(0.5f, direction.y);
        }
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * movespeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            //direction = Vector2.Reflect(direction, collision.contacts[0].normal);
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Debug.Log("paddle hit");
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Capsule"))
        {
            //direction = Vector2.Reflect(direction, collision.contacts[0].normal);
            direction = Vector2.Reflect(direction, collision.contacts[0].normal);
        }
    }


   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("BarrierLinks"))
        {
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
            ResetBall();
        }
        if (collision.gameObject.CompareTag("BarrierRechts"))
        {
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
            ResetBall();
        }
    }


    private void ResetBall()
    {
        transform.position = new Vector2(0, 0);
        direction = new Vector2(Random.Range(1f, 1f), Random.Range(-1f, 1f));
        direction = direction.normalized;
    }

}
