using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private FloatVariable towerHealth;
    [SerializeField]
    private float towerStartHealth = 100f;
    [SerializeField]
    private GameObject[] spawners; 
    [SerializeField]
    private FloatVariable score;
    private int i;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

    [SerializeField]
    private float spawnRate;
    [SerializeField]
    private float spawnRateDecrement;
    [SerializeField]
    private float spawnRateMinimum;
    private float timer;
    private int index;
>>>>>>> c966bb4 (feat: Basic game)
>>>>>>> a13b961 (feat: Basic game)
>>>>>>> 1c0b68a (feat: Basic game)
    
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
	timer = 0f;
>>>>>>> c966bb4 (feat: Basic game)
>>>>>>> a13b961 (feat: Basic game)
>>>>>>> 1c0b68a (feat: Basic game)
	score.value = 0f;
	towerHealth.value = towerStartHealth;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (towerHealth.value <= 0)
	{
	    SceneManager.LoadScene("loss", LoadSceneMode.Single);
=======
<<<<<<< HEAD
        if (towerHealth.value <= 0)
	{
	    SceneManager.LoadScene("loss", LoadSceneMode.Single);
=======
<<<<<<< HEAD
        if (towerHealth.value <= 0)
	{
	    SceneManager.LoadScene("loss", LoadSceneMode.Single);
=======
	timer += Time.deltaTime;

	if (timer > spawnRate)
	{
	    timer = 0f;
	    index = Random.Range(0, spawners.Length);
	    
	    spawners[index].SetActive(true);
	    spawners[index].SetActive(false);
	    
	    if (spawnRate > spawnRateMinimum) spawnRate -= spawnRateDecrement;
	}
	
        if (towerHealth.value <= 0)
	{
	    SceneManager.LoadScene("loss", LoadSceneMode.Single);
	    // |   ||
	    // ||  |_
>>>>>>> c966bb4 (feat: Basic game)
>>>>>>> a13b961 (feat: Basic game)
>>>>>>> 1c0b68a (feat: Basic game)
	}
    }
}
