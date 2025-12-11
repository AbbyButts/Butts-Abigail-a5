using UnityEngine;

public class Platforms : MonoBehaviour
{
    public float speed;
    public float distance;
    private Rigidbody2D rb;
    private Vector2 startPosition;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
        startPosition = transform.position;
    }

    
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, distance);
        rb.MovePosition(new Vector2(startPosition.x + x, startPosition.y));
    }
}
