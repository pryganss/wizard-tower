using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float t = 0;
    private Vector3 startPosition;
    [SerializeField]
    private Vector3 target = new Vector3(0f, 0f, 0f);
    public float time = 10;
    [SerializeField]
    private GameObject coin;
    
    void Start()
    {
	startPosition = transform.position;
    }
    
    void FixedUpdate()
    {
        t += Time.fixedDeltaTime / time;
	transform.position = Vector3.Lerp(startPosition, target, t);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
	if (col.gameObject.tag == "Bullet")
	{
	    Destroy(col.gameObject);
	    for (int i = 0; i < Random.Range(0,4); i++)
		Instantiate(coin, transform.position, Quaternion.identity);
	    Destroy(gameObject);
	}
    }
}
