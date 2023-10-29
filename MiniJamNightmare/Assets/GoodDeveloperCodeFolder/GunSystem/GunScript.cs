using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float offset;
    private float time;
    public float startTime;

    public GameObject bullet;
    public Transform point;

    public Animator animator;

    public int MaxGunAmmo = 30;
    public int GunAmmo = 30;

    public TextMeshProUGUI AmmoText;

    public AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        GunAmmo = MaxGunAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        AmmoText.text = string.Format($"Ammo:{GunAmmo}");
        //Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        if (time <= 0f)
        {
            if (Input.GetMouseButton(0) && GunAmmo >= 1)
            {
                GunAmmo -= 1;
                AudioSource.Play();
                Instantiate(bullet, point.position, point.transform.rotation);
                time = startTime;
                animator.Play("MuzzleFlashAnim");
            }
        }
        else
        {
            time -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            GunAmmo = MaxGunAmmo;
        }
    }
}
