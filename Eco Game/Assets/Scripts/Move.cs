using UnityEngine;

public class Move : MonoBehaviour
{
	public float speed = 15;

	public Vector2 velocity = Vector2.zero;
	Rigidbody2D rb = default!;

    private void Awake()
	{
		rb = GetComponent<Rigidbody2D>(); 
	}
	private void Update()
	{
		velocity.x = Input.GetAxisRaw("Horizontal");
		velocity.y = Input.GetAxisRaw("Vertical");
	}

	private void FixedUpdate()
	{
		rb.MovePosition(rb.position + speed * Time.fixedDeltaTime * velocity);
	}

	public string GetDirection()
	{
		if (velocity.x < 0) return "left";
		else if (velocity.x > 0) return "right";
		else if (velocity.y > 0) return "up";
		else if (velocity.y < 0) return "down";
		else return "stop";
    }
}