using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator _anim; 

    public int health;
    public GameObject destroyEffect;
    public GameObject bloodSplash;

    [SerializeField] private Room room;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            room.EnemyKilled(gameObject);

            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Instantiate(Resources.Load("Coin"), transform.position, Quaternion.identity);
            _anim.SetTrigger("death");
            Destroy(gameObject,1f);
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
}
