using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    [SerializeField]
    private FloatVariable score;

    void Start()
    {
	GetComponent<Text>().text = string.Format("You scored {0:0}. Press any key to play again", score.value);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) 
	    SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
