using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class KillCount : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text KillCountText;
    public TMP_Text HighScoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KillCountText.text = "Kills: " + ZombieHealth.kills.ToString();
        HighScoreText.text = "Highscore: " + ZombieHealth.highscore.ToString();
    }
}
