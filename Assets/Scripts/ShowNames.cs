using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNames : MonoBehaviour
{

    public Text NamesText;

    // Update is called once per frame
    void Update()
    {
        string names = "";
        if (Variables.leaderboard.Count > 0) {
            for (int i = 0; i < Variables.leaderboard.Count; ++i) {
                names = names + Variables.leaderboard[i].playerName + "\n";
            }
        };
        NamesText.text = names;

    }
}
