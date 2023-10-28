using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{
    [SerializeField] private GameObject menu;

    [SerializeField] private GameplayManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate(int roomsCleared)
    {

    }

    public void Upgrade(int upgrade)
    {
        menu.SetActive(false);
        gameManager.Upgrade(upgrade);
    }
}
