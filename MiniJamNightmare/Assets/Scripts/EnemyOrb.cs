using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOrb : MonoBehaviour
{
    [SerializeField] private float speed;

    public GameObject destroyEffect;

    private Vector2 direction;

    void Awake()
    {
        direction = new Vector2();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.right * direction.x + Vector3.up * direction.y) * speed * Time.deltaTime);
    }

    public void SetDirection(Vector2 d)
    {
        direction = d.normalized;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground") Explode();
    }

    public void Explode()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
