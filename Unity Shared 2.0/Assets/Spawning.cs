using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(0, 100), 24, Random.Range(0, 110));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}