using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Transform _target;
    [SerializeField] float _speed;
    Vector3 _actualScale;
    Vector3 _changeScale;
    [SerializeField]float _radiusVision;
    Rigidbody2D rb;
    //private bool CanAttack;

    private void Start()
    {
        _actualScale = transform.localScale;
        _changeScale = transform.localScale;
        _changeScale.x *= -1;
        _target = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        _target = GameObject.Find("Player").transform;
        //if (CanAttack)
        //{
        DirectionScale();
        if (Vector2.Distance(transform.position, _target.position) < _radiusVision)
        {
            Vector2 direction = (_target.position - transform.position).normalized;
            rb.velocity = direction * _speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        //}
        //DirectionScale();
        //transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    void DirectionScale()
    {
        if(transform.position.x > _target.position.x)
        {
     
            transform.localScale = _actualScale;
        }
        else
        {
    
            transform.localScale = _changeScale;
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            CanAttack = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            CanAttack = false;
        }
    }
    */
}
