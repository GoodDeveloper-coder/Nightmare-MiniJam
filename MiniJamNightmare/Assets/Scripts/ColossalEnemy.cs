using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColossalEnemy : MonoBehaviour
{
    [SerializeField] private GameplayManager gameManager;

    [SerializeField] private GameObject explosionPrefab;

    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Animator _anim;

    [SerializeField] private float initialMovementSpeed = 1f;
    [SerializeField] private float movementSpeedIncrement = 0.1f;

    [SerializeField] private float animationSpeedFactor = 0.5f;

    private float currentMovementSpeed;

    private bool active;

    public AudioSource AudioSourceFootSteps;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentMovementSpeed = initialMovementSpeed;
        StartCoroutine(FootStepsSound());
        _anim.speed = initialMovementSpeed * animationSpeedFactor;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        //if (!active) return;
        rb.MovePosition(rb.position + Vector2.right * currentMovementSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Ground")
        {
            Destroy(other.transform.gameObject);
            for (int i = 0; i < 7; i++) Instantiate(explosionPrefab, other.transform.position + Vector3.up * (0.5f + i - 3.5f), transform.rotation);
            return;
        }
    }

    public void SetActive(bool a)
    {
        active = a;
    }

    public void SpeedUp()
    {
        currentMovementSpeed += movementSpeedIncrement;
        _anim.speed = currentMovementSpeed * animationSpeedFactor;
    }

    IEnumerator FootStepsSound()
    {
        yield return new WaitForSeconds(3f * initialMovementSpeed / currentMovementSpeed);
        AudioSourceFootSteps.Play();
        StartCoroutine(FootStepsSound());
    }
}
