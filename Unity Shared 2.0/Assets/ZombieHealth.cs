using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public int health = 100;
    public static int bulletDamage = 1;
    public GameObject cubePrefab;
    public static int kills = 0;
    public GameObject healthPrefab;
    public static int highscore = 0;

    public GameObject hp;
    public GameObject dp;

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

    

    //When player gets shot
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            if(health > bulletDamage){
                health = health - 10*bulletDamage;
                
            } else {
                int healthRandom = Random.Range(1, 10);
                if(healthRandom < 6)
                {
                    Instantiate(healthPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                }
                Vector3 randomSpawnPosition = new Vector3(Random.Range(25, 150), 24, Random.Range(25, 150));
                //health += 100;
                //Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
                transform.position += randomSpawnPosition;
                health += 100;
                kills += 1;
                if(kills > highscore)
                {
                    highscore = kills;
                }
            }

            //ROUND SYSTEM
            if (kills % 10 == 0 && kills > 9)
            {
                bulletDamage ++;
                health += 10;
                hp.transform.position = new Vector3(74.54f,22.82f,44.57f);
                dp.transform.position = new Vector3(75.84f,22.82f,46.09f);
                Debug.Log(bulletDamage);
                Debug.Log(health);
            }

            
        }
    }
}
