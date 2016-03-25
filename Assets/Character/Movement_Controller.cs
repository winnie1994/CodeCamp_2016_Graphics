using UnityEngine;
using System.Collections;

public class Movement_Controller : MonoBehaviour {

	//sets the maximum speed
	public float maximum_horizontal_speed = 10f;
	public float maximum_vertical_speed = 10f;
	private Rigidbody2D rigid_body;
	// Use this for initialization
	void Start () {
		rigid_body = GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal_input = Input.GetAxis ("Horizontal");
		float vertical_input = Input.GetAxis ("Vertical");
		rigid_body.velocity = new Vector2 (horizontal_input * maximum_horizontal_speed, vertical_input * maximum_vertical_speed);
	}
}
