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
    
    // Start is called before the first frame update
    void Start()
    {
	score.value = 0f;
	towerHealth.value = towerStartHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (towerHealth.value <= 0)
	{
	    SceneManager.LoadScene("loss", LoadSceneMode.Single);
	}
    }
}
