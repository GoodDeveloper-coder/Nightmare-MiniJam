using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;

    [SerializeField] private GameObject panel;

    [SerializeField] private GameObject[] upgrades;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        foreach (GameObject u in upgrades) u.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        panel.SetActive(true);
        int r1 = Random.Range(0, upgrades.Length / 3);
        int r2;
        do r2 = Random.Range(0, upgrades.Length / 3);
        while (r1 == r2);
        int r3;
        do r3 = Random.Range(0, upgrades.Length / 3);
        while (r1 == r3 || r2 == r3);
        foreach (GameObject u in upgrades) u.SetActive(false);
        upgrades[r1 * 3].SetActive(true);
        upgrades[r2 * 3 + 1].SetActive(true);
        upgrades[r3 * 3 + 2].SetActive(true);
    }

    public void Upgrade(int upgrade)
    {
        panel.SetActive(false);
        foreach (GameObject u in upgrades) u.SetActive(false);
        gameManager.Upgrade(upgrade);
    }
}