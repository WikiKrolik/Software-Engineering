using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
	public float speed = 15;

	Vector2 velocity;
	Rigidbody2D rb;

    public Move() {}

    private void Awake()
	{
		rb = GetComponent<Rigidbody2D>(); velocity = Vector2.zero;
	}
	private void Update()
	{
		velocity.x = Input.GetAxisRaw("Horizontal");
		velocity.y = Input.GetAxisRaw("Vertical");
	}

	private void FixedUpdate()
	{
		rb.MovePosition(rb.position + velocity * speed * Time.fixedDeltaTime);
	}

	public string getDirection()
	{
		float velx = velocity.x = Input.GetAxisRaw("Horizontal");
		float vely = velocity.y = Input.GetAxisRaw("Vertical");

		if (velx < 0) return "left";
		else if (velx > 0) return "right";
		else if (vely > 0) return "up";
		else if (vely < 0) return "down";
		else return "stop";
    }
}