using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    [SerializeField]
    private float health;
    private float damage = 10f;

    [SerializeField]
    private FloatVariable towerHealth;
    
    void OnCollisionEnter2D(Collision2D col)
    {
	switch (col.gameObject.tag)
	{
	case "Enemy":
	    Destroy(col.gameObject);
	    towerHealth.value -= damage;
	    break;
	case "Bullet":
	    Destroy(col.gameObject);
	    break;
	    
	default:
	    break;
	}   
    }
}
