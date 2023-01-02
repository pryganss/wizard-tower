using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToStory : MonoBehaviour
{
    void Update()
    {
	if (Input.GetKeyDown("q"))
	    Application.Quit();
        else if (Input.anyKeyDown) 
	    SceneManager.LoadScene("story", LoadSceneMode.Single);
    }
}
