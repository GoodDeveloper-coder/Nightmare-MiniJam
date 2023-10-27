using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    public float speed;
    public float distance;
    public int damage;
    public GameObject destroyEffect;
    public GameObject bloodSplash;
    public LayerMask layerMask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.up, distance, layerMask);
        if (other.collider != null)
        {
            if (other.collider.CompareTag("Enemy"))
            {
                other.collider.GetComponent<Enemy>().TakeDamage(damage);
                Destroy();
            }

            if (other.collider.CompareTag("Ground"))
            {
                Destroy();
            }
        }

        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    void Destroy()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Instantiate(bloodSplash, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
