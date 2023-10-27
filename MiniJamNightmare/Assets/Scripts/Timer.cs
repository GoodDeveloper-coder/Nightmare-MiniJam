using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI _tmp;
    [SerializeField] float _currentTime;
    // Start is called before the first frame update
    void Start()
    {
        _tmp = GetComponent<TextMeshProUGUI>();
        _tmp.text = "00:00";
    }

    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;
        float minutes = (int)_currentTime / 60;
        float seconds = (int)_currentTime % 60;
        _tmp.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
