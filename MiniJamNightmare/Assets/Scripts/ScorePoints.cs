using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorePoints : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _tmp;
    int score = 0;

    public void AddCoin(int points) { score += points; _tmp.text = "" + score; }
}
