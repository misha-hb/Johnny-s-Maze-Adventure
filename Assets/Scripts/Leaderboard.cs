using System;

[Serializable]
public class Leaderboard 
{

    public string playerScore;
    public string playerName;

    public Leaderboard (string name, string score) {
        playerName = name;
        playerScore = score;
    }
}
