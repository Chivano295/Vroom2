using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] spawnpoints;
    [SerializeField]private GameObject gun;
    [SerializeField] private GameObject[] items;

    public void Start()
    {
        SpawnObjects();
    }

    public void SpawnObjects()
    {
        int random = Random.RandomRange(0, 3);

        
        Instantiate(items[Random.Range(0 ,5)], spawnpoints[random]);
    }
}
