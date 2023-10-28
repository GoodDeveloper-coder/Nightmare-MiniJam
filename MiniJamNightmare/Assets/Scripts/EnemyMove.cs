using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Animator _anim;
    [SerializeField] float _speed;
    [SerializeField] Transform _player;
    // Start is called before the first frame update

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Direction();
        transform.position = Vector2.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);
    }

    public void Direction()
    {
        if(transform.position.x > _player.position.x)
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
    public void Death() => _anim.SetTrigger("");
}
