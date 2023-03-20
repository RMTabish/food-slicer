using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawner : MonoBehaviour
{
    public GameObject[] vegetables;
    public Transform spawnPoint;
    public float intervalBetweenSpawn;
    private float spawnBetweenTime;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spawnBetweenTime <= 0)
        {
            int rand = Random.Range(0, vegetables.Length);
            Instantiate(vegetables[rand], spawnPoint.position, Quaternion.identity);
            spawnBetweenTime = intervalBetweenSpawn;

        }
        else
        {
            spawnBetweenTime -= Time.deltaTime;
        }
    }
}
