using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDeScore : MonoBehaviour
{
    public static int valorScore = 0;
    public Text score;
    void Start()
    {
        score = GetComponent<Text>();
    }

    
    void Update()
    {
        score.text = "Tu score: " + valorScore;
    }
}
