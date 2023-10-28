using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public static SpawnEnemy Instance;

    [SerializeField]  Transform[] _spawnPostion;
    int _randomPos;
    float _timeSpawn=1f;
    string _typeEnemy="Monster";
    // Start is called before the first frame update

    private void Awake() => Instance = this; 
    
    void Start() => StartCoroutine(Spawn());

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(_timeSpawn);
        while (true)
        {
            _randomPos = Random.RandomRange(0, _spawnPostion.Length);
            Instantiate(Resources.Load(_typeEnemy), _spawnPostion[_randomPos].position,Quaternion.identity);
            yield return new WaitForSeconds(_timeSpawn);
        }
        
    }

    public void SetTimeSpawn(float time) => _timeSpawn = time;
    public void SetTimeSpawn(string enemy) => _typeEnemy = enemy;
}
