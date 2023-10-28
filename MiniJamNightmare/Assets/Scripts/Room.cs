using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;
    
    [SerializeField] private GameObject[] enemyPrefabs;

    private GameObject[] enemies;

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
        
    }

    public void EnemyDown(GameObject enemy)
    {
        for (int i = 0; i < enemies.Length; i++) if (enemy == enemies[i]) enemies[i] = null;
    }
}
