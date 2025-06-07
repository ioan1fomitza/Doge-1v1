using UnityEngine;

public class Ronaldo : MonoBehaviour
{
    public float moveSpeed = 7.5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);
        rb.velocity = movement * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RapidP")
        {
            moveSpeed *= 10.5f; // Increase speed by 10.5x
            Destroy(collision.gameObject); // Remove the potion after use (optional)
        }
    }
}



