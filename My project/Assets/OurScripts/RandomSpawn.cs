using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public Transform[] spawnpoints;
    [SerializeField]private GameObject gun;
    [SerializeField] private GameObject[] items;
    [SerializeField] private int itemAmount = 5;
    [SerializeField] private GameObject[] currentItems;
 
    public void Start()
    {
        SpawnObjects();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            CallSpawn();
        }
    }
    public void SpawnObjects()
    {
        for (int i = 0; i < itemAmount; i++)
        {
            currentItems[i] = Instantiate(items[Random.Range(0, 10)], spawnpoints[i]);
        }
            

    }

    public void CallSpawn()
    {     
         GameObject.Destroy(currentItems[0]);
        GameObject.Destroy(currentItems[1]);
        GameObject.Destroy(currentItems[2]);
        GameObject.Destroy(currentItems[3]);
        GameObject.Destroy(currentItems[4]);
        SpawnObjects();
    }
}
