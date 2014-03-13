using UnityEngine;
using System.Collections;

/// <summary>
/// Player controller and behavior. 
/// Initially programmed by Jaxson.
/// </summary>
public class PlayerScript : MonoBehaviour {

	//Speed of Player.

	public Vector2 speed = new Vector2(25, 0); //This is for movement in both x and y

	private Vector2 movement;
	private float jumpPower = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (jumpPower > 0) { jumpPower --; }
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		if (Input.GetKeyDown(KeyCode.Space))
		    {
			jumpPower = 1;
			}

		movement = new Vector2(speed.x * inputX, speed.y * jumpPower );

	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}
