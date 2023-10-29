using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Transform _target;
    [SerializeField] float _speed;
    //private bool CanAttack;

    [SerializeField] private Animator _anim;

    [SerializeField] private float animationSpeedFactor = 0.5f;

    [SerializeField] private float minOrbInterval;
    [SerializeField] private float maxOrbInterval;

    [SerializeField] private GameObject orbPrefab;

    private Vector3 _scale;

    private bool active;

    private float orbInterval;
    private float orbTime;

    private void Start()
    {
        _target = GameObject.Find("Player").transform;
        orbInterval = Random.Range(minOrbInterval, maxOrbInterval);
        _scale = transform.localScale;
        _anim.speed = _speed * animationSpeedFactor;
    }
    // Update is called once per frame
    void Update()
    {
        if (!active) return;
        if (orbPrefab != null) OrbManagement();
        //if (CanAttack)
        //{
        DirectionScale();
        transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        //}
        //DirectionScale();
        //transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    public void Activate()
    {
        active = true;
    }

    public void Deactivate()
    {
        active = false;
    }

    private void OrbManagement()
    {
        orbTime += Time.deltaTime;
        if (orbTime >= orbInterval)
        {
            orbTime = 0;
            orbInterval = Random.Range(minOrbInterval, maxOrbInterval);
            GameObject orb = Instantiate(orbPrefab, transform.position, transform.rotation);
            Vector3 distance = _target.position - transform.position;
            orb.GetComponent<EnemyOrb>().SetDirection(new Vector2(distance.x, distance.y));
        }
    }

    void DirectionScale()
    {
        transform.localScale = transform.position.x > _target.position.x ? transform.localScale = new Vector3(-_scale.x, _scale.y, _scale.z) : _scale;
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
