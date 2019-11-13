using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour
{

    public bool playerTurn;

    // Start is called before the first frame update
    void Start()
    {
        playerTurn = true;
    }

    public void OnTurnPassed()
    {
        playerTurn = !playerTurn;

        if(playerTurn)
        {
            Debug.Log("Now it's the player turn");
        }
        else
        {
            Debug.Log("Now it's the AI turn");
        }
    }



}
