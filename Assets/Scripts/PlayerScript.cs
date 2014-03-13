using UnityEngine;
using System.Collections;

/// <summary>
/// Player controller and behavior. 
/// Initially programmed by Jaxson.
/// </summary>
public class PlayerScript : MonoBehaviour {

	//Speed of Player.

	public Vector2 speed = new Vector2(25, 0); //This is for movement in both x and y

	private Vector2 movement; //Movement holds the actual speed of player. It is input axis times speed. 
	private float jumpPower = 0; //LATER...

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis("Horizontal"); //Get axis of controller (instead of button presses!) as per http://docs.unity3d.com/Documentation/ScriptReference/Input.GetAxis.html
		float inputY = Input.GetAxis("Vertical");


		movement = new Vector2(speed.x * inputX, speed.y * jumpPower );

	}

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}
