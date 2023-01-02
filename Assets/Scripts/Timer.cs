using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float timerStart;
    private float timer;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        timer = timerStart;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
	GetComponent<Text>().text = string.Format("{0:0}", timer);

	if (timer <= 0 )
	    SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }
}
