using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColossalEnemy : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;

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

    public void SetActive(bool a)
    {
        active = a;
    }
}
