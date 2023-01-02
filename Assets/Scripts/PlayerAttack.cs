using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Transform bulletTransform;
    private bool canFire;
    private float timer;
    [SerializeField]
    private float fireRate;
    [SerializeField]
    private float bufferTime;
    private float bufferCounter;

    
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	canFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

	Vector3 rotation = mousePos - transform.position;

	float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
	transform.rotation = Quaternion.Euler(0, 0, rotZ);

	if(!canFire)
	{
	    timer += Time.deltaTime;
	    if (timer > fireRate) { canFire = true; timer = 0; }
	}

	if (Input.GetMouseButtonDown(0))
	{
	    bufferCounter = bufferTime;
	} else bufferCounter -= Time.deltaTime;

	if ((bufferCounter > 0 ) && canFire)
	{
	    canFire = false;
	    Instantiate(bullet, bulletTransform.position, Quaternion.identity);
	    bufferCounter = 0f;
	}
    }
}
