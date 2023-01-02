using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private FloatVariable score;
    private float timer = 0f;
    private float timeBefore = 3f;
    private bool timerExpired = false;
    
    void Start()
    {
	GetComponent<Text>().text = string.Format("You scored {0:0}. Press any key to play again, or press q to quit", score.value);
    }
    
    // Update is called once per frame
    void Update()
    {
	timer += Time.deltaTime;

	if (timerExpired || timer > timeBefore)
	    if (Input.GetKeyDown("q"))
		Application.Quit();
	    else if (Input.anyKeyDown) 
		SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
