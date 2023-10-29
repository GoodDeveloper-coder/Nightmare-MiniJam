using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;
    
    [SerializeField] private GameObject[] enemyPrefabs;

    [SerializeField] private GameObject gate;

    private GameObject[] enemies;
    private bool clear;
    private int randomIndex;

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
        if (roomIndex % 3 > 0)
        {
            int r;
            do r = Random.Range(0, 5);
            while (randomIndex == r);
            randomIndex = r;
        }
        List<GameObject> enemyList = new List<GameObject>();
        switch (roomIndex)
        {
            case 0:
                for (int i = 0; i < 3; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                break;
            case 1:
                for (int i = 0; i < 5; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                break;
            case 2:
                for (int i = 0; i < 7; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                break;
            case 3:
                for (int i = 0; i < 2; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                break;
            case 4:
                for (int i = 0; i < 4; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                break;
            case 5:
                for (int i = 0; i < 2; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 2; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                break;
            case 6:
                for (int i = 0; i < 5; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 2; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 7:
                for (int i = 0; i < 5; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 8:
                for (int i = 0; i < 2; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 3; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 9:
                for (int i = 0; i < 6; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 2; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 10:
                for (int i = 0; i < 6; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 11:
                for (int i = 0; i < 4; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 4; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 12:
                for (int i = 0; i < 5; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                break;
            case 13:
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 14:
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 15:
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 16:
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 17:
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 18:
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 19:
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                for (int i = 0; i < 1; i++) enemyList.Add(Instantiate(enemyPrefabs[2], transform.position, transform.rotation));
                break;
            case 20:
                for (int i = 0; i < 50; i++) enemyList.Add(Instantiate(enemyPrefabs[1], transform.position, transform.rotation));
                break;
        }
        enemies = enemyList.ToArray();
        Vector3 offset = Vector3.right * 5f;
        int[] x = new int[enemies.Length];
        int[] y = new int[enemies.Length];
        for (int i = 0; i < enemies.Length; i++)
        {
            int rX = 0;
            int rY = 0;
            bool matchX = true;
            bool matchY = true;
            do
            {
                if (matchX) rX = Random.Range(0, enemies.Length);
                if (matchY) rY = Random.Range(0, enemies.Length);
                matchX = false;
                matchY = false;
                for (int j = 0; j < i; j++)
                {
                    matchX |= rX == x[j];
                    matchY |= rY == y[j];
                }
            }
            while (matchX || matchY);
            x[i] = rX;
            y[i] = rY;
            enemies[i].transform.position += offset + Vector3.right * (rX + 0.5f - enemies.Length / 2f) * 5f + Vector3.up * (rY + 0.5f - enemies.Length / 2f) * 3.5f;
            enemies[i].GetComponent<Enemy>().SetRoom(this);
        }
        clear = false;
    }

    public void Activate(PlayerScript p)
    {
        foreach (GameObject e in enemies) e.GetComponent<Enemy>().Activate(p);
    }

    public void EnemyKilled(GameObject enemy)
    {
        clear = true;
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemy == enemies[i]) enemies[i] = null;
            else if (enemies[i] != null) clear = false;
        }
        if (clear) Destroy(gate);
    }

    public bool GetClear()
    {
        return clear;
    }
}
