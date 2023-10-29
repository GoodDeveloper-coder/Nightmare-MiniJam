using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject destroyEffect;
    public GameObject bloodSplash;

    [SerializeField] private Room room;

    private bool active;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!active) return;
        if (health <= 0)
        {
            room.EnemyKilled(gameObject);

            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Instantiate(bloodSplash, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    private void Die()
    {

    }

    public void SetRoom(Room r)
    {
        room = r;
    }

    public void Activate(PlayerScript p)
    {
        active = true;
        //player = p;
    }
}
