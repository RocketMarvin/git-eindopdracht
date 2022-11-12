using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speler : MonoBehaviour
{
    public int spelerNummer;
    [SerializeField]
    Material inactiefMat;
    [SerializeField]
    Material actiefMat;
    [SerializeField]
    Transform TankBody;
    bool aanDeBeurt = false;
    public int MoveSpeed;

    public void zetBeurt(bool b)
    {
        if (b == true)
        {
            GetComponent<MeshRenderer>().material = actiefMat;
            Invoke("SetTrue", 0.2f);
        }
        else
        {
            aanDeBeurt = false;
            GetComponent<MeshRenderer>().material = inactiefMat;
        }
    }

    void SetTrue()
    {
        aanDeBeurt = true;
    }

    private void Update()
    {
        if (aanDeBeurt == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log(spelerNummer);
                GameObject.Find("GameEngine").GetComponent<TurnEngine>().wisselBeurt();
            }
            TankBody.Translate(Input.GetAxis("Player1Movement") * MoveSpeed * Time.deltaTime, 0f, 0f);
        }
    }
}
