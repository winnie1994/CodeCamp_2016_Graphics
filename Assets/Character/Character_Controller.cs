using UnityEngine;
using System.Collections;

public class Character_Controller : BaseClass {

	public float max_speed = 10f;

	//all in degrees
	public float initial_angle = 0f;
	public float delta_angle = 10f;
	public float max_angle = 30f;
	public float min_angle = -30f;

	public float initial_position = 0f;
	public float right_boundary = 6f;
	public float left_boundary = -6f;

	public Rigidbody2D bullet;
	public float bullet_speed = 20;

	private float position;
	private float angle;


	//PREWRITTEN
	void Start () 
	{
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
		
		if (Input.GetKeyDown ("space"))
			ShootBullet (bullet, bullet_speed);
	}

	void EnemyCollided()
	{
		LoseLife ();
        SetTemporaryColor(Color.magenta, 0.5f);
        position = initial_position;
		MoveTo(position);   
	}
}
