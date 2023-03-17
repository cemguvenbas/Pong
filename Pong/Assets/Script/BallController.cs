using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float speed;
    void Start()
    {
        rigidbody2D.AddForce(Vector2.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Racket"))
        {
            var racket = collision.transform.GetComponent<RacketController>();
            var direction = racket.isUp ? Vector2.down : Vector2.up;
            rigidbody2D.AddForce(direction);
        }
    }
}
