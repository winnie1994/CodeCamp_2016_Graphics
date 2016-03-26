using UnityEngine;
using System.Collections;

public class Movement_Controller : MonoBehaviour {

	//sets the maximum speed
	public float maximum_horizontal_speed = 10f;
	public float init_angle = 0f;
	public float delta_angle = 10f; //degrees
	public Vector2 angle_range = new Vector2(-80f, 80f); //degrees

	private Rigidbody2D rigid_body;
	private Vector2 initial_position;
	private float angle;

	// Use this for initialization
	void Start () {
		rigid_body = GetComponent<Rigidbody2D> ();
		initial_position = rigid_body.position;
		angle = init_angle;
	}
	
	// Update is called once per frame
	void Update () {

		float horizontal_input = Input.GetAxis ("Horizontal");
		rigid_body.velocity = new Vector2 (horizontal_input * maximum_horizontal_speed,0);

		if (Input.GetKeyDown ("z") && angle < angle_range[1])
			RotateLeft ();
		else if (Input.GetKeyDown ("x") && angle > angle_range[0])
			RotateRight ();
		
	}
		
	void RotateLeft() {
		transform.Rotate (0f, 0f, delta_angle);
		angle += delta_angle;
	}
		
	void RotateRight() {
		transform.Rotate (0f, 0f, -delta_angle);
		angle -= delta_angle;
	}

	void EnemyHit(){
		Scoreboard_Controller scoreboard = GameObject.Find("GameController_Object").GetComponent<Scoreboard_Controller>();
		scoreboard.LoseLife ();
		rigid_body.position = initial_position;
	}

}
