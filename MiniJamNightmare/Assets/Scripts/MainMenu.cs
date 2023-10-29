using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject helpMenu;
    [SerializeField] private GameObject creditsMenu;

    // Start is called before the first frame update
    void Start()
    {
        Main();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Main()
    {
        mainMenu.SetActive(true);
        helpMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }

    public void Help()
    {
        mainMenu.SetActive(false);
        helpMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }

    public void Credits()
    {
        mainMenu.SetActive(false);
        helpMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene("TestDungeon");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
