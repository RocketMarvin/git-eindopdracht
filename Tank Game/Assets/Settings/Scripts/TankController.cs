using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [SerializeField]
    Transform BarrelRotater;
    [SerializeField]
    Transform Firepoint;
    [SerializeField]
    GameObject bulletToFire;
    [SerializeField]
    Transform TankBody;
    public int MoveSpeed;
    public int spelerNummer;
    public bool aanDeBeurt = false;
    public float Power = 10;
    public Text AllPower;
    public Animator TankAmin;
    BulletController bullet;


    // Update is called once per frame
    void Update()
    {
        if (aanDeBeurt)
        {
            BarrelRotater.RotateAround(Vector3.forward, Input.GetAxis("Player1Barrel") * Time.deltaTime);
            TankBody.Translate(Input.GetAxis("Player1Movement") * MoveSpeed * Time.deltaTime, 0f, 0f);

            if (Input.GetAxis("Player1Movement") != 0)
            {
                TankAmin.SetBool("TankAmin", true);
            }
            else
            {
                TankAmin.SetBool("TankAmin", false);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameObject b = Instantiate(bulletToFire, Firepoint.position, Firepoint.rotation);
                aanDeBeurt = false;
                if (spelerNummer == 1)
                {
                    b.GetComponent<Rigidbody2D>().AddForce(BarrelRotater.right * Power, ForceMode2D.Impulse);
                }
                else if (spelerNummer == 2)
                {
                    b.GetComponent<Rigidbody2D>().AddForce(BarrelRotater.right * -Power, ForceMode2D.Impulse);
                }
               
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                IncreasePower();
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                DecreasePower();
            }
            
            
        }

        
    }

    public void zetBeurt(bool b)
    {
        Debug.Log("Zetbeurt " + spelerNummer + " " + b);
        if (b == true)
        {
            Invoke("SetTrue", 0.2f);
        }
        else
        {
            aanDeBeurt = false;
        }
    }

    void SetTrue()
    {
        aanDeBeurt = true;
    }

    public void IncreasePower()
    {
        Power += 1;
        AllPower.text = Power.ToString();
    }

    public void DecreasePower()
    {
        Power -= 1;
        AllPower.text = Power.ToString();
    }
    

}
