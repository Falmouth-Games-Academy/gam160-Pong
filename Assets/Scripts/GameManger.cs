using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    //Player Scores
    public int playerOneScore=0;
    public int playerTwoScore=0;

    //Player Score UI
    public Text playerOneScoreText;
    public Text playerTwoScoreText;

    //Ball Prefab
    public GameObject ballPrefab;

    //Start Game
    public void StartGame()
    {
        Instantiate<GameObject>(ballPrefab);
    }

    //Increase Player One's score and display
    public void OnPlayerOneScored()
    {
        playerOneScore++;
        playerOneScoreText.text = playerOneScore.ToString();
    }

    //Increase Player Two's score and display
    public void OnPlayerTwoScored()
    {
        playerTwoScore++;
        playerTwoScoreText.text = playerTwoScore.ToString();
    }

}
