using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> a13b961 (feat: Basic game)
>>>>>>> 1c0b68a (feat: Basic game)
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
    [SerializeField]
    private GameObject enemyPrefab;
    
    void OnEnable()
    {
	Instantiate(enemyPrefab, transform.position, Quaternion.identity);
>>>>>>> c966bb4 (feat: Basic game)
>>>>>>> a13b961 (feat: Basic game)
>>>>>>> 1c0b68a (feat: Basic game)
    }
}
