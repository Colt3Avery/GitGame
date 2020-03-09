using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private const float xRange = 10;
    private const float spawnPointZ = 25;
   
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 2.0f, 0.6f);
    }

    
    void Update()
    {
        
    }

    // creating a method for spawning animals
    void SpawnAnimals()
    {
        int randamals = Random.Range(0, animals.Length);
        Instantiate(animals[randamals], new Vector3(Random.Range(-xRange, xRange), 0, spawnPointZ), animals[randamals].transform.rotation);
    }
}
