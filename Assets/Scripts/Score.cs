using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private FloatVariable score;
<<<<<<< Updated upstream
<<<<<<< HEAD
=======
<<<<<<< HEAD
<<<<<<< HEAD
=======
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
=======
=======
>>>>>>> Stashed changes
>>>>>>> 579f106 (feat: Final Game)
>>>>>>> c663221 (feat: Final Game)
    [SerializeField]
    private float goal = 50f;
    [SerializeField]
    private GameObject timer;
<<<<<<< Updated upstream
>>>>>>> c966bb4 (feat: Basic game)
<<<<<<< HEAD
>>>>>>> a13b961 (feat: Basic game)
<<<<<<< HEAD
>>>>>>> 1c0b68a (feat: Basic game)
=======
=======
=======
>>>>>>> Stashed changes
>>>>>>> 579f106 (feat: Final Game)
>>>>>>> c663221 (feat: Final Game)
    
    // Update is called once per frame
    void Update()
    {
	GetComponent<Text>().text = string.Format("{0:0}", score.value);
<<<<<<< Updated upstream
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
	if (score.value >= goal) timer.SetActive(true);
	
>>>>>>> c966bb4 (feat: Basic game)
<<<<<<< HEAD
>>>>>>> a13b961 (feat: Basic game)
<<<<<<< HEAD
>>>>>>> 1c0b68a (feat: Basic game)
=======
=======
=======
	if (score.value >= goal) timer.SetActive(true);
	
>>>>>>> Stashed changes
>>>>>>> 579f106 (feat: Final Game)
>>>>>>> c663221 (feat: Final Game)
    }
}
