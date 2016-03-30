using UnityEngine;
using System.Collections;

public class Character_Controller : BaseClass {

	public float horizontal_speed = 0.1f;

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
        SetEnemySpeedRange(1, 2);
		SetColor (Color.white);
		MoveTo (initial_position);
		RotateTo (initial_angle);
	}
	
	// FILL IN
	void Update () 
	{
		if (Input.GetKeyDown ("z") && angle < max_angle)
			RotateLeft ();
		
		if (Input.GetKeyDown ("x") && angle > min_angle)
			RotateRight ();

		if (Input.GetKey ("space"))
			ShootBullet (bullet, bullet_speed);

		if (Input.GetKey ("right") && position < right_boundary)
			MoveRight ();

		if (Input.GetKey ("left") && position > left_boundary)
			MoveLeft ();
	}

	void EnemyCollided()
	{
        
		LoseLife ();
        SetTemporaryColor(Color.magenta, 0.5f);
        position = initial_position;
		MoveTo(position); 
        
	}
		
	void MoveRight() 
	{
		position += horizontal_speed;
		MoveTo (position);
	}

	void MoveLeft() 
	{
		position -= horizontal_speed;
		MoveTo (position);
	}

	void RotateLeft() 
	{
		angle += delta_angle;
		RotateTo (angle);
	}

	void RotateRight() 
	{
		angle -= delta_angle;
		RotateTo (angle);
	}

}
