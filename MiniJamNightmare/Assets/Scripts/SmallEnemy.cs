using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float movementSpeed;
    [SerializeField] private float health;

    private bool moveLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
