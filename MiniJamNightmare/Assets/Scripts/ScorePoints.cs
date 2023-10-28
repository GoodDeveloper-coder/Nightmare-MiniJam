using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePoints : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _tmp;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCoin(int points) { score += points; _tmp.text = "" + score; }
}
