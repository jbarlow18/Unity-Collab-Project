using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NewBehaviourScript : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    float horizontalMove = 0f;
    public float runSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
        enemy.SetDestination(Player.position);
    }
}
