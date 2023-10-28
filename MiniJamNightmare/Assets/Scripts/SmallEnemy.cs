using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Player player;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float health;

    private bool active;

    // Start is called before the first frame update
    void Start()
    {
        player = gameManager.GetPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (!active) return;
        // return if player is immobilised
        Vector3 distance = player.transform.position - transform.position;
        if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y)) rb.MovePosition(rb.position + new Vector2((distance.x < 0 ? -1 : 1) *  movementSpeed * Time.deltaTime, 0));
        else rb.MovePosition(rb.position + new Vector2(0, (distance.y < 0 ? -1 : 1) * movementSpeed * Time.deltaTime));
    }
}
