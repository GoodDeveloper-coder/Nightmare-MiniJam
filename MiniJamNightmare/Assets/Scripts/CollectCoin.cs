using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectCoin : MonoBehaviour
{
    TextMeshProUGUI _tmp;

    [SerializeField] float _speed;
     Transform _player;
    [SerializeField]float limitDistance;

    int score=0;
    // Start is called before the first frame update
    private void Start()
    {
        _player = GameObject.Find("Player").transform;
        _tmp = GameObject.Find("Coin_Counter").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
       if(Vector2.Distance(transform.position,_player.position) < limitDistance)
        transform.position = Vector2.MoveTowards(transform.position, _player.position, _speed * Time.deltaTime);
    }

    public void AddCoin(int points) { score += points; _tmp.text = "" + score; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name== "Player")
        {
            AddCoin(20);
            Destroy(gameObject);
        }
    }


}
