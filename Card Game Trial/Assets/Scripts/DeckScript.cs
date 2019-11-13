using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour
{
    public CardScript[] cardsArray;

    private void Awake()
    {
        cardsArray = gameObject.GetComponentsInChildren<CardScript>();
        if(cardsArray.Length <= 0)
        {
            Debug.Log("No cards inside the deck!");
        }
    }
    
}
