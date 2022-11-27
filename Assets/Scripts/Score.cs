using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private FloatVariable score;
    
    // Update is called once per frame
    void Update()
    {
	GetComponent<Text>().text = string.Format("{0:0}", score.value);
    }
}
