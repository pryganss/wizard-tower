using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
	if (Input.GetKeyDown("q"))
	    Application.Quit();
        else if (Input.anyKeyDown) 
	    SceneManager.LoadScene("tutorial", LoadSceneMode.Single);
    }
}
