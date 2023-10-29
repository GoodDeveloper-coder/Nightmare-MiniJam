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
        if (roomIndex <= 0)
        {
            switch (randomIndex)
            {
                case 0:
                    enemyList.Add(Instantiate(enemyPrefabs[0], transform.position, transform.rotation));
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
        else if (roomIndex < 3)
        {

        }
        else if (roomIndex < 6)
        {

        }
        else if (roomIndex < 9)
        {

        }
        else if (roomIndex < 12)
        {

        }
        enemies = enemyList.ToArray();
        foreach (GameObject e in enemies) e.GetComponent<Enemy>().SetRoom(this);
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
