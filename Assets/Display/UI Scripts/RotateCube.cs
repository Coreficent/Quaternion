using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public float speed = 10f;
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
            
    }

    public void ChangeSpeed (float newSpeed)
    {
        speed = newSpeed;
    }
}


//ref https://www.youtube.com/watch?v=HQ8Tttcksu4