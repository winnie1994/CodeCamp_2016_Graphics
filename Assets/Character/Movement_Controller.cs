using UnityEngine;
using System.Collections;

public class Movement_Controller : BaseClass {

	public float max_speed = 10f;

	//all in degrees
	public float initial_angle = 0f;
	public float delta_angle = 10f;
	public float max_angle = 30f;
	public float min_angle = -30f;

	public float initial_position = 0f;
	public float right_boundary = 6f;
	public float left_boundary = -6f;

	private float position;
	private float angle;

	//PREWRITTEN
	void Start () {
		SetColor (Color.white);
		MoveTo (initial_position);
		RotateTo (initial_angle);
	}
	
	// FILL IN
	void Update () {
		float horizontal_input = Input.GetAxis ("Horizontal");
		float vertical_input = Input.GetAxis ("Vertical");
		Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2(max_speed*horizontal_input, max_speed*vertical_input);
		
	}

	void EnemyCollided(){
		Scoreboard_Controller scoreboard = GetScoreboard ();
		scoreboard.LoseLife ();
		//SetColor (Color.red);
		MoveTo(initial_position);
		//SetColor (Color.white);
	}

}
