using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColossalEnemy : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;

    [SerializeField] private GameObject explosionPrefab;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float initialMovementSpeed;
    [SerializeField] private float movementSpeedIncrement;

    private float currentMovementSpeed;

    private bool active;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        active = false;
        currentMovementSpeed = initialMovementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (!active) return;
        rb.MovePosition(rb.position + Vector2.right * currentMovementSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            Destroy(collision.transform.gameObject);
            for (int i = 0; i < 7; i++) Instantiate(explosionPrefab, collision.transform.position + Vector3.up * (1f + i - 7f) / 2f, transform.rotation);
            return;
        }
    }

    public void SetActive(bool a)
    {
        active = a;
    }

    public void SpeedUp()
    {
        currentMovementSpeed += movementSpeedIncrement;
    }
}
