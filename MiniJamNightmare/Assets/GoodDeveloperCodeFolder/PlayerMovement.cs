using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public float speed;
    private Vector2 direction;
    private Rigidbody2D rb;
    
    public float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if (direction.x == 0 && direction.y == 0) return;
        rb.MovePosition(rb.position + direction.normalized * speed * Time.fixedDeltaTime);
    }

    public void SetSpeed(float s)
    {
        speed = s;
    }

    public Vector2 GetPosition()
    {
        return rb.position;
    }
}
