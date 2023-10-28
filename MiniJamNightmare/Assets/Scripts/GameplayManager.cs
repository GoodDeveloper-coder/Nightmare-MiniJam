using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] private UpgradeMenu upgradeMenu;

    [SerializeField] Player player;
    [SerializeField] ColossalEnemy colossal;

    [SerializeField] private GameObject roomPrefab;

    [SerializeField] private Room previousRoom;
    [SerializeField] private Room currentRoom;
    [SerializeField] private Room nextRoom;

    private int score;
    private int roomsCleared;

    // Start is called before the first frame update
    void Start()
    {
        currentRoom.GenerateEnemies(0);
        nextRoom.GenerateEnemies(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Transform cam = Camera.main.transform;
        cam.position = new Vector3(player.transform.position.x, cam.position.y, cam.position.z);
        if (!currentRoom.GetClear()) return;
        roomsCleared++;
        previousRoom = currentRoom;
        currentRoom = nextRoom;
        nextRoom = Instantiate(roomPrefab, transform.position = Vector3.right * 15, transform.rotation).GetComponent<Room>();
        nextRoom.GenerateEnemies(roomsCleared);
    }

    public Player GetPlayer()
    {
        return player;
    }
}
