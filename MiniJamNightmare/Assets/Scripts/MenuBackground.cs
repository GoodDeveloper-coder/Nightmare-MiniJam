using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBackground : MonoBehaviour
{
    [SerializeField] private GameObject roomPrefab;
    [SerializeField] private float panSpeed;
    private GameObject[] rooms;

    // Start is called before the first frame update
    void Start()
    {
        rooms = new GameObject[5];
        for (int i = 0; i < rooms.Length; i++) rooms[i] = Instantiate(roomPrefab, transform.position + Vector3.right * (0.5f + i - rooms.Length / 2f) * 30, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject r in rooms) r.transform.position += Vector3.right * (r.transform.position.x > (1 - rooms.Length) * 15 ? -panSpeed * Time.deltaTime : 30 * rooms.Length);
    }
}
