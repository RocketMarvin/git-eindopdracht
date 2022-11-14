using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCapsules : MonoBehaviour
{
    public float Rotate;
    public ScoreScript scoreScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        

        if (scoreScript.Player1Score >= 5)
        {
            rotateCapsule();
        }
        if (scoreScript.Player2Score >= 5)
        {
            rotateCapsule();
        }
        
    }

    void rotateCapsule()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * Rotate);
    }
}
