using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _pause;
    bool _screenPause=false;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        ConditionPause();


    }

    public void ButtonContinue() { _pause.SetActive(false); Time.timeScale = 1; _screenPause = false; }
    public void ButtonRestart() => SceneManager.LoadScene("");

    public void ConditionPause()
    {
        if (!_screenPause && Input.GetKeyDown(KeyCode.Escape))
        {
            _pause.SetActive(true);
            Time.timeScale = 0;
            _screenPause = true;
        }
       else if (_screenPause && Input.GetKeyDown(KeyCode.Escape))
        {
            _pause.SetActive(false);
            Time.timeScale = 1;
            _screenPause = false;
        }
    }
}
