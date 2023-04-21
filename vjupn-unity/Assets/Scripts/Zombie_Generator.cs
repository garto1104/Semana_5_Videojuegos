using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Generator : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval = 3f;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnInterval, spawnInterval);
    }

    void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
