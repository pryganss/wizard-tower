using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
<<<<<<< Updated upstream
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> a13b961 (feat: Basic game)
>>>>>>> 1c0b68a (feat: Basic game)
    public float spawnInterval = 0f;

=======
>>>>>>> Stashed changes
    [SerializeField]
    private GameObject enemyPrefab;
    
    void OnEnable()
    {
<<<<<<< Updated upstream
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
<<<<<<< HEAD
>>>>>>> a13b961 (feat: Basic game)
<<<<<<< HEAD
>>>>>>> 1c0b68a (feat: Basic game)
=======
=======
=======
	Instantiate(enemyPrefab, transform.position, Quaternion.identity);
>>>>>>> Stashed changes
>>>>>>> 579f106 (feat: Final Game)
>>>>>>> c663221 (feat: Final Game)
    }
}
