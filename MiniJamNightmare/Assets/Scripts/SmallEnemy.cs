using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private PlayerScript player;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float health;

    [SerializeField] private Room room;

    private bool active;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (!active) return;
        //Vector3 distance = player.transform.position - transform.position;
        //if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y)) rb.MovePosition(rb.position + new Vector2((distance.x < 0 ? -1 : 1) *  movementSpeed * Time.deltaTime, 0));
        //else rb.MovePosition(rb.position + new Vector2(0, (distance.y < 0 ? -1 : 1) * movementSpeed * Time.deltaTime));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.gameObject == player.gameObject)
        {
            room.EnemyKilled(gameObject);
            Destroy(gameObject);
        }
    }

    public void SetRoom(Room r)
    {
        room = r;
    }

    public void Activate(PlayerScript p)
    {
        active = true;
        player = p;
    }
}
