using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnTimer = 2f;
    private float _nextTimeSpawn;
    
    private void Update()
    {
        if (Time.time >= _nextTimeSpawn)
        {
            _nextTimeSpawn = Time.time + spawnTimer;
            Instantiate(enemyPrefab, this.transform.position, Quaternion.identity, this.transform);
        }
    }
}
