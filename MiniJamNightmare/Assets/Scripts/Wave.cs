using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wave : MonoBehaviour
{
    public static Wave Instance;

    [SerializeField] SpawnEnemy _spawnEnemy;
    [SerializeField] Image _image;
    [SerializeField]float _currentSpawn;
    [SerializeField]float _maxSpawn;
    [SerializeField] float _speed;
    private void Awake() => Instance = this;

    // Start is called before the first frame update
    void Start()
    {
        _currentSpawn = _currentSpawn / _maxSpawn;
        _image.fillAmount = _currentSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        _currentSpawn += Time.deltaTime* _speed;
        _image.fillAmount = _currentSpawn / _maxSpawn;

        //Desactivate script SpawnEnemy
        if (_currentSpawn >= 100) _spawnEnemy.enabled = false;
    }

    public void set_currentSpawn(float _spawn) => _currentSpawn = _spawn;
}
