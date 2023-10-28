using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;
    
    [SerializeField] private GameObject[] enemyPrefabs;

    private GameObject[] enemies;
    private bool clear;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateEnemies(int roomIndex)
    {
        
        clear = false;
    }

    public void EnemyKilled(GameObject enemy)
    {
        clear = true;
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemy == enemies[i]) enemies[i] = null;
            else if (enemies[i] != null) clear = false;
        }
    }

    public bool GetClear()
    {
        return clear;
    }
}
