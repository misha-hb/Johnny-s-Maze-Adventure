using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class EnterName : MonoBehaviour
{

    public Button enterButton;
    public GameObject fieldText;
    public GameObject currentScore;
    public GameObject field;

    void Start() {
        if (Variables.timerText != null) {
            field.SetActive(true);
            enterButton.gameObject.SetActive(true);
            currentScore.SetActive(true);
        }
        else {
            field.SetActive(false);
            enterButton.gameObject.SetActive(false);
            currentScore.SetActive(false);
        }
        Variables.leaderboard = FileHandler.ReadListFromJSON<Leaderboard>(Variables.fileName);
       
    }

    public void handleClick() {
        TextMeshProUGUI mText = fieldText.GetComponent<TextMeshProUGUI>();
        Variables.leaderboard.Add(new Leaderboard (mText.text, Variables.timerText));
        FileHandler.SaveToJSON<Leaderboard> (Variables.leaderboard, Variables.fileName);
        field.SetActive(false);
        enterButton.gameObject.SetActive(false);
    }

    public void handleBackClick() {
        SceneManager.LoadScene(0);
        Variables.timerText = null;
    }
}
