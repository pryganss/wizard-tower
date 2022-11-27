using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnInterval = 0f;

    [SerializeField]
    private GameObject enemyPrefab;
    [SerializeField]
    private Transform spawnerLocation;
    
    void OnEnable()
    {
        StartCoroutine(spawnEnemy(spawnInterval, enemyPrefab, spawnerLocation.position));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy, Vector3 position)
    {
	yield return new WaitForSeconds(interval);
	Instantiate(enemy, position, Quaternion.identity);
	StartCoroutine(spawnEnemy(interval, enemy, position));
    }
}
