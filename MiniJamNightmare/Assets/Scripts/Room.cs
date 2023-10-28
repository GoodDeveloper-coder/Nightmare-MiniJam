using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;

    [SerializeField] private GameObject wallPrefab;
    [SerializeField] private GameObject floorPrefab;
    [SerializeField] private GameObject upgradePrefab;
    [SerializeField] private GameObject[] enemyPrefabs;

    private GameObject[] elements;

    private bool entered;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateRoom()
    {
        if (elements != null)
        {
            foreach (GameObject e in elements) Destroy(e);
        }

    }
}
