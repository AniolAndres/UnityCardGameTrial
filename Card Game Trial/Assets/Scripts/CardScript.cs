using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public void OnTurnPassed()
    {
        Debug.Log("Card with name " + gameObject.name + " was activated");
    }
}
