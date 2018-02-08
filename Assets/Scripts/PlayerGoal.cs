using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoal : MonoBehaviour {

    //We need the game manager to interact with scores
    GameManger gameManger;
    
    //This ID matches the player number (1 for player one, 2 for player two)
    public int PlayerID = 0;


    private void Start()
    {
        //Get the Game Manager
        gameManger = GameObject.Find("GameManager").GetComponent<GameManger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy the ball
        Destroy(collision.gameObject);
        
        //if the player ID is one, call the player one score function in game manager 
        if (PlayerID==1)
        {
            gameManger.OnPlayerOneScored();
        }
        //else if the player ID is two, call the player two score function in game manager
        else if (PlayerID==2)
        {
            gameManger.OnPlayerTwoScored();
        }

        //restart the game
        gameManger.StartGame();
    }
}
