using UnityEngine;

public class BallController : MonoBehaviour
{
    public static BallController Instance { get; private set; }
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float speed;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
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
            var directionVertical = racket.isUp ? -1 : 1;

            var directionHorizontal = (transform.position.x - racket.transform.position.x) / collision.collider.bounds.extents.x;
            
            rigidbody2D.AddForce(new Vector2(directionHorizontal,directionVertical).normalized * speed);
        }
    }
}
