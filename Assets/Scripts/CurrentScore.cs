using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CurrentScore : MonoBehaviour
{

    public Text currentScore;

    void Start()
    {
        if (Variables.timerText != null) {
            currentScore.text = "Current Score: " + Variables.timerText;
        }
    }
}
