using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject spawnEnemies;
    public bool mustSpawn;
    public int timeToSpawn;
    public int timeToActive;
    void Start()
    {
        StartCoroutine(Activation());
    }

    void Update()
    {
        if (mustSpawn) StartCoroutine(Spawning());
    }

    public IEnumerator Activation()
    {
        yield return new WaitForSeconds(timeToActive);
        mustSpawn = true;
    }

    public IEnumerator Spawning()
    {
        mustSpawn = false;
        Instantiate(spawnEnemies, spawnPoint);
        yield return new WaitForSeconds(timeToSpawn);
        mustSpawn = true;
    }
}
