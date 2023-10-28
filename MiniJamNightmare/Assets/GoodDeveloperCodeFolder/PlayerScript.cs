using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float PlayerHP = 1;
    public Scrollbar ScrollbarPlayerHP;
    public GameObject DeathMenu;
    bool FixTime = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScrollbarPlayerHP.size = PlayerHP;

        if (PlayerHP <= 0 )
        {
            TimeFix();
            //Destroy(this.gameObject);
            DeathMenu.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            PlayerHP -= 0.1f;
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
}
