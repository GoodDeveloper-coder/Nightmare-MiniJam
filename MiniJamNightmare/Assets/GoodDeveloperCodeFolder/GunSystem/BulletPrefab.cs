using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    public float speed;
    public float distance;
    public float damage;
    public GameObject destroyEffect;
    public GameObject bloodSplash;
    public LayerMask layerMask;

    public float TimeAfterDisappearBullet = 6f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.up, distance, layerMask);
        if (other.collider != null)
        {
            //if (other.collider.isTrigger == false)
            //{
                if (other.collider.CompareTag("Enemy"))
                {
                    other.collider.GetComponent<Enemy>().TakeDamage(damage);
                    DestroyEnemy();
                }

                if (other.collider.CompareTag("Ground"))
                {
                    DestroyGround();
                }
            //}

        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyEnemy()
    {
        //Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Instantiate(bloodSplash, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void DestroyGround()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        //Instantiate(bloodSplash, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(TimeAfterDisappearBullet);
        Destroy(this.gameObject);
    }
}
