using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsDestroyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyEffectTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator DestroyEffectTimer()
    {
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }
}
