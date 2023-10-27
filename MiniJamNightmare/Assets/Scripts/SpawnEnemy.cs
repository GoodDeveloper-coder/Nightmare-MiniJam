using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]  GameObject[] _spawnPoints;
    int _randomPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator Spawn()
    {
        _randomPos = Random.RandomRange(0, _spawnPoints.Length);
        

        yield return new WaitForSeconds(2);
    }
}
