using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] ColossalEnemy colossal;
    [SerializeField] private string[] rooms;

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
}
