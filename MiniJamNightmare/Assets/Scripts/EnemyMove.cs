using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Transform _target;
    [SerializeField] float _speed;

    private void Start()
    {
        _target = GameObject.Find("Player").transform;
    }
    // Update is called once per frame
    void Update()
    {
        DirectionScale();
        transform.position = Vector2.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }

    void DirectionScale()
    {
        if(transform.position.x > _target.position.x)
        {
            Vector3 _newScale = new Vector3(-4, 4, 1);
            transform.localScale = _newScale;
        }
        else
        {
            Vector3 _newScale = new Vector3(4, 4, 1);
            transform.localScale = _newScale;
        }
    }
}
