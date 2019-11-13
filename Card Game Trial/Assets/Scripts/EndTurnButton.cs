using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnButton : MonoBehaviour
{
    Color firstColor;

    delegate void OnTurnPassed();
    OnTurnPassed OnTurnDelegate;

    public TurnScript turn;
    public DeckScript playerDeck;

    // Start is called before the first frame update
    void Start()
    {
        firstColor = gameObject.GetComponent<SpriteRenderer>().color;
        OnTurnDelegate += turn.OnTurnPassed;
        foreach(CardScript card in playerDeck.cardsArray)
        {
            OnTurnDelegate += card.OnTurnPassed;
        }
    }

    private void OnMouseDown()
    {
        OnTurnDelegate();
        
        if(turn.playerTurn)
        {
            gameObject.GetComponent<SpriteRenderer>().color = firstColor;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
}
