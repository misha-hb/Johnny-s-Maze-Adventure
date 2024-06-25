using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScores : MonoBehaviour
{

    public Text ScoresText;

    // Update is called once per frame
    void Update()
    {
        string scores = "";
        if (Variables.leaderboard.Count > 0) {
            for (int i = 0; i < Variables.leaderboard.Count; ++i) {
                scores = scores + Variables.leaderboard[i].playerScore + "\n";
            };
        }
        ScoresText.text = scores;
    }
}
