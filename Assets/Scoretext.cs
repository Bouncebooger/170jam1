using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoretext : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoret;
    private float score;

    public void Start()
    {
        score = 0;
    }
    public void scoreenemy()
    {
        score += 10;
        scoret.text = "Score" + score;
    }

}
