using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 75 * Time.deltaTime, 0); //rotates 50 degrees per second around z axis
    }
}
