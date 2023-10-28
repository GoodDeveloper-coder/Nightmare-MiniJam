using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePoints : MonoBehaviour
{
    public static ScorePoints Instance;
    [SerializeField] TextMeshProUGUI _tmp;
    [SerializeField]int score = 0;

    private void Start() => Instance = this;
    
    public void AddCoin(int points) { score += points; _tmp.text = "" + score; }
}
