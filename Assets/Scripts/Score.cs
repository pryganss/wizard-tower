using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private FloatVariable score;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
    [SerializeField]
    private float goal = 50f;
    [SerializeField]
    private GameObject timer;
>>>>>>> c966bb4 (feat: Basic game)
>>>>>>> a13b961 (feat: Basic game)
>>>>>>> 1c0b68a (feat: Basic game)
    
    // Update is called once per frame
    void Update()
    {
	GetComponent<Text>().text = string.Format("{0:0}", score.value);
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
	if (score.value >= goal) timer.SetActive(true);
	
>>>>>>> c966bb4 (feat: Basic game)
>>>>>>> a13b961 (feat: Basic game)
>>>>>>> 1c0b68a (feat: Basic game)
    }
}
