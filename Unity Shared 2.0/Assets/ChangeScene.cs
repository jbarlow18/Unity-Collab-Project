using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SomeScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
        if(Input.anyKey)
        {
            SceneManager.LoadScene(1);
        }
    }
}