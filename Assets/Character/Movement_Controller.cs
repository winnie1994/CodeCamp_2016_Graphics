﻿using UnityEngine;
using System.Collections;

public class Movement_Controller : BaseClass {

	public float horizontal_speed = 0.1f;

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
		if (Input.GetKeyDown ("z") && angle < max_angle)
			RotateLeft ();
		if (Input.GetKeyDown ("x") && angle > min_angle)
			RotateRight ();
		if (Input.GetKey ("right") && position < right_boundary)
			MoveRight ();
		if (Input.GetKey ("left") && position > left_boundary)
			MoveLeft ();
		
	}

	void EnemyCollided(){
		Scoreboard_Controller scoreboard = GetScoreboard ();
		scoreboard.LoseLife ();
		//SetColor (Color.red);
		MoveTo(initial_position);
		//SetColor (Color.white);
	}
		
	void MoveRight() {
		position += horizontal_speed;
		MoveTo (position);
	}

	void MoveLeft() {
		position -= horizontal_speed;
		MoveTo (position);
	}

	void RotateLeft() {
		angle += delta_angle;
		RotateTo (angle + delta_angle);
	}

	void RotateRight() {
		angle -= delta_angle;
		RotateTo (angle - delta_angle);
	}

}
