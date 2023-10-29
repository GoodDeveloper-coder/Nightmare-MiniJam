using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public float PlayerHP = 1f;
    public Scrollbar ScrollbarPlayerHP;
    public GameObject DeathMenu;
    bool FixTime = true;

    [SerializeField] private PlayerMovement movementScript;

    [SerializeField] private float maxHP = 10;
    [SerializeField] private float initialMovementSpeed;
    [SerializeField] private float movementSpeedUpgrade;
    [SerializeField] private float initialFireRate;
    [SerializeField] private float fireRateUpgrade;
    [SerializeField] private float initialOffense = 1;
    [SerializeField] private float offenseUpgrade;
    [SerializeField] private float initialDefense = 1;
    [SerializeField] private float defenseUpgrade;
    [SerializeField] private float initialMaxAmmo;
    [SerializeField] private float maxAmmoUpgrade;

    private Room room;
    private float currentHP;
    private float movementSpeed;
    private float fireRate;
    private float offense;
    private float defense;
    private float maxAmmo;
    private float ammo;

    public float PlayerTakeEnemyDamage = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = GetComponent<PlayerMovement>();
        movementSpeed = initialMovementSpeed;
        movementScript.SetSpeed(movementSpeed);
        currentHP = maxHP;
        offenseUpgrade = initialOffense;
        defense = initialDefense;
        maxAmmo = initialMaxAmmo;
        ammo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        ScrollbarPlayerHP.size = PlayerHP;

        if (PlayerHP <= 0)
        {
            GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            PlayerHP -= PlayerTakeEnemyDamage;
        }
    }

    private void TimeFix()
    {
        if (FixTime)
        {
            Time.timeScale = 0f;
            FixTime = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.tag == "Trigger")
        {
            Destroy(collider.transform.gameObject);
            room.Activate();
        }
        else if (collider.transform.tag == "Colossal") GameOver();
        else if (collider.transform.tag == "Orb")
        {
            collider.transform.gameObject.GetComponent<EnemyOrb>().Explode();
            PlayerHP -= PlayerTakeEnemyDamage;
        }
    }

    private void GameOver()
    {
        TimeFix();
        //Destroy(this.gameObject);
        DeathMenu.SetActive(true);
    }

    public void SetRoom(Room r)
    {
        room = r;
    }
}
