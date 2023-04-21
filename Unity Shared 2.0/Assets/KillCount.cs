using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class KillCount : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text KillCountText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KillCountText.text = "Kills: " + ZombieHealth.kills.ToString();
    }
}
