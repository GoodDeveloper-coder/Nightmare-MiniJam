using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    ScorePoints _score;

    [SerializeField] float _speed;
     Transform _player;
    [SerializeField]float limitDistance;

    public int points = 20;
    // Start is called before the first frame update
    private void Start() { _player = GameObject.Find("Player").transform; _score = ScorePoints.Instance; }

    

    // Update is called once per frame
    void Update()
    {
       if(Vector2.Distance(transform.position,_player.position) < limitDistance)
        transform.position = Vector2.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name== "Player")
        {
            _score.AddCoin(points);
            Destroy(gameObject);
        }
    }


}
