using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    //Vector3 pos;
    //Camera main;
    public float offset;
    //public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        //main = FindObjectOfType<Camera>();
        //pos = main.WorldToScreenPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
        /*
        if (Input.mousePosition.x < pos.x)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.mousePosition.x > pos.x)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        */
    }


}
