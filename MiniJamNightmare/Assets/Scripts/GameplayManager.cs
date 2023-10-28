using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] ColossalEnemy colossal;
    [SerializeField] private string[] rooms;

    [SerializeField] private GameObject newRoomTrigger;

    [SerializeField] private Room previousRoom;
    [SerializeField] private Room currentRoom;
    [SerializeField] private Room nextRoom;

    private int score;
    private int roomsCleared;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Transform cam = Camera.main.transform;
        cam.position = new Vector3(player.transform.position.x, cam.position.y, cam.position.z);
        if (!player.GetNewRoomTrigger()) return;
        // generate new room
        newRoomTrigger.transform.position += Vector3.right * 20;
    }

    public Player GetPlayer()
    {
        return player;
    }
}
