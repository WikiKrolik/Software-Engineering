using Photon.Pun;
using UnityEngine;

public class Move : MonoBehaviour
{
	public float speed = 15;
	public PhotonView view = default!;

	public Vector2 velocity = Vector2.zero;
	Rigidbody2D rb = default!;

    private void Start()
	{
		rb = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
    }

    private void Update()
	{
		if (view.IsMine)
		{
            velocity.x = Input.GetAxisRaw("Horizontal");
            velocity.y = Input.GetAxisRaw("Vertical");
        }
	}

	private void FixedUpdate()
	{
		if (view.IsMine)
		{
            rb.MovePosition(rb.position + speed * Time.fixedDeltaTime * velocity);
        }
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