using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    //public GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAgain(int SceneIndex)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneIndex);
    }

    public void Play()
    {
        SceneManager.LoadScene(2);
    }

    public void Pause(AudioSource AudioPause)
    {
        //PauseMenu.SetActive(true);
        AudioPause.Play();
        Time.timeScale = 0f;
    }

    public void UnPause(AudioSource AudioUnPause)
    {
        //PauseMenu.SetActive(false);
        AudioUnPause.Play();
        Time.timeScale = 1f;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;        
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
