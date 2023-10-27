using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    Vector3 pos;
    Camera main;

    // Start is called before the first frame update
    void Start()
    {
        main = FindObjectOfType<Camera>();
        pos = main.WorldToScreenPoint(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x < pos.x)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.mousePosition.x > pos.x)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }


}
