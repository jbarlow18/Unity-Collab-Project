using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text healthText;
    public TMP_Text damageText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + PlayerDamage.PlayerHealth.ToString();
    }
}
