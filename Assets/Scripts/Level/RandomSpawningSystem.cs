using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawningSystem : MonoBehaviour
{
    // Unity serialized variables
    [SerializeField] GameObject prefab;
    [SerializeField] int spawnCount;

    private void Awake()
    {
        SpawnCubes();
    }

    public void SpawnCubes()
    {
        for (int i = 0; i < spawnCount; i++)
        { 
            Instantiate(prefab);
        }
    }
}
