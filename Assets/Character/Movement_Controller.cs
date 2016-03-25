using UnityEngine;
using System.Collections;

public class Movement_Controller : MonoBehaviour {

	//sets the maximum speed
	public float maximum_horizontal_speed = 10f;
<<<<<<< Updated upstream
=======
	public float maximum_vertical_speed = 10f;
	public float init_angle = 0f;
	public float delta_angle = 10f; //degrees
	public Vector2 angle_range = new Vector2(-80f, 80f);

>>>>>>> Stashed changes
	private Rigidbody2D rigid_body;
	private float angle;

	// Use this for initialization
	void Start () {
		rigid_body = GetComponent<Rigidbody2D> ();	
		angle = init_angle;
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal_input = Input.GetAxis ("Horizontal");
<<<<<<< Updated upstream
		float vertical_input = Input.GetAxis ("Vertical");
		rigid_body.velocity = new Vector2 (horizontal_input * maximum_horizontal_speed,0);

=======
		rigid_body.velocity = new Vector2 (horizontal_input * maximum_horizontal_speed, 0);

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
>>>>>>> Stashed changes
	}
}
