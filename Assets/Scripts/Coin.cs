using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float timer = 0;
    [SerializeField]
    private float cooldown = 3;
    [SerializeField]
    private FloatVariable score;
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
	if (timer > cooldown) Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
	if (col.gameObject.tag == "Player")
	{
	    score.value += 1f;
	    Destroy(gameObject);
	}
    }	
}
