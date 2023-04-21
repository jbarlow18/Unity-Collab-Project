using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public int health = 100;
    public int bulletDamage = 10;
    public GameObject cubePrefab;
    public static int kills = 0;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        cubePrefab = GameObject.Find("Zombie1");
        //Destroy(gameObject);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            if(health > 10 ){
                health = health - bulletDamage;
                Debug.Log("Health: " + health);
            } else {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(25, 150), 24, Random.Range(25, 150));
                //health += 100;
                //Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
                transform.position += randomSpawnPosition;
                health += 100;
                kills += 1;
            }
        }
    }
}
