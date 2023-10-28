using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]  Transform[] _spawnPostion;
    int _randomPos;
    float timeSpawn=1f;
    // Start is called before the first frame update
    void Start() => StartCoroutine(Spawn());

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timeSpawn);
        while (true)
        {
            _randomPos = Random.RandomRange(0, _spawnPostion.Length);
            Instantiate(Resources.Load("Monster"), _spawnPostion[_randomPos].position,Quaternion.identity);
            yield return new WaitForSeconds(timeSpawn);
        }
        
    }

    public void SetTimeSpawn(float time) => timeSpawn = time;
}
