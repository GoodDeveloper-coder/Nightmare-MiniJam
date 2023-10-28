using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float initialMovementSpeed;
    [SerializeField] private float movementSpeedUpgrade;
    [SerializeField] private float immobilityDuration;
    [SerializeField] private float immobilityUpgrade;

    private bool inputMoveLeft;
    private bool inputMoveRight;
    private bool inputJump;
    private bool onGround;

    [SerializeField] private Vector2 input;
    private bool active;
    private float immobilityTime;

    private bool newRoomTrigger;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        input = new Vector2();
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!active) return;
        if (immobilityTime > 0)
        {
            immobilityTime -= Time.deltaTime;
            return;
        }
        bool newInputMoveLeft = Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A);
        bool newInputMoveRight = Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D);
        bool newInputJump = onGround && Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W);
        inputMoveLeft = newInputMoveLeft;
        inputMoveRight = newInputMoveRight;
        inputJump = newInputJump;
        if (inputJump) onGround = false;
    }

    void FixedUpdate()
    {
        if (!active) return;
        rb.MovePosition(rb.position + input * Time.deltaTime);
    }

    public void SetActive(bool a)
    {
        active = a;
    }

    public bool GetNewRoomTrigger()
    {
        return newRoomTrigger;
    }
}
