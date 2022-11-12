using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEngine : MonoBehaviour
{
    public int playerTurn = 1;
    public GameObject player1;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject g in players)
        {
            if (g.GetComponent<TankController>().spelerNummer == 1)
            {
                player1 = g;
            }
            if (g.GetComponent<TankController>().spelerNummer == 2)
            {
                player2 = g;
            }
        }
        player1.GetComponent<TankController>().zetBeurt(true);
        player2.GetComponent<TankController>().zetBeurt(false);
    }

    public void wisselBeurt()
    {
        if (playerTurn == 1)
        {
            
            playerTurn = 2;
            player1.GetComponent<TankController>().zetBeurt(false);
            player2.GetComponent<TankController>().zetBeurt(true);
            return;
        }

        else if (playerTurn == 2)
        {
           
            playerTurn = 1;
            player1.GetComponent<TankController>().zetBeurt(true);
            player2.GetComponent<TankController>().zetBeurt(false);
            return;
        }
    }
}