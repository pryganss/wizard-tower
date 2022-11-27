using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    [SerializeField]
    public float force;
    private Vector2 screenBounds;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
	rb = GetComponent<Rigidbody2D>();
	mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
	Vector3 direction = mousePos - transform.position;
	Vector3 rotation = transform.position - mousePos;
	rb.velocity = new Vector3(direction.x, direction.y).normalized * force;
	float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
	transform.rotation = Quaternion.Euler(0, 0, rot);

        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    void LateUpdate()
    {
	if ((transform.position.x > screenBounds.x) | (transform.position.x * -1 > screenBounds.x) |
	    (transform.position.y > screenBounds.y) | (transform.position.y * -1 > screenBounds.y)) Destroy(gameObject);
    }
}
