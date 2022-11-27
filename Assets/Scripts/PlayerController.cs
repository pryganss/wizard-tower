using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 5f;
    
    private Vector2 movement;
    
    void Update()
    {
	movement.x = Input.GetAxisRaw("Horizontal");
	movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
	transform.position = new Vector2(
	    transform.position.x + (movement.x * playerSpeed * Time.fixedDeltaTime),
	    transform.position.y + (movement.y * playerSpeed * Time.fixedDeltaTime));
    }
}
