using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolkjesSpawner : MonoBehaviour
{
   
    public GameObject Wolkjes;
    public float MoveSpeed = 1.5f;
    bool SpawnWolk = false;
    int WolkSpawnRate = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnwolk", 5, WolkSpawnRate );

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void spawnwolk()
    {
        
        int randomy = Random.Range(-10, 15);
        Vector3 spawnPos = new Vector3(-60, randomy, 0);
        Instantiate(Wolkjes, spawnPos, Quaternion.identity);
    }

  
}

