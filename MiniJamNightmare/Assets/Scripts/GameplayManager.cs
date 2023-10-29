using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private GameObject hUD;
    [SerializeField] private UpgradeMenu upgradeMenu;

    [SerializeField] PlayerScript player;
    [SerializeField] ColossalEnemy colossal;

    [SerializeField] private GameObject roomPrefab;

    [SerializeField] private Room previousRoom;
    [SerializeField] private Room currentRoom;
    [SerializeField] private Room nextRoom;

    private int score;
    private int roomsCleared;
    private bool clear;

    // Start is called before the first frame update
    void Start()
    {
        currentRoom.GenerateEnemies(0);
        nextRoom.GenerateEnemies(1);
        player.SetRoom(currentRoom);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Transform cam = Camera.main.transform;
        cam.position = new Vector3(player.transform.position.x, cam.position.y, cam.position.z);
        if (clear || !currentRoom.GetClear()) return;
        clear = true;
        NextRoom();
    }

    private void NextRoom()
    {
        roomsCleared++;
        hUD.SetActive(false);
        upgradeMenu.Activate();
        previousRoom = currentRoom;
        currentRoom = nextRoom;
        player.SetRoom(currentRoom);
        nextRoom = Instantiate(roomPrefab, currentRoom.transform.position + Vector3.right * 30, transform.rotation).GetComponent<Room>();
        nextRoom.GenerateEnemies(roomsCleared);
        colossal.SpeedUp();
    }

    public void Upgrade(int upgrade)
    {
        clear = false;
        hUD.SetActive(true);
    }

    public PlayerScript GetPlayer()
    {
        return player;
    }
}
