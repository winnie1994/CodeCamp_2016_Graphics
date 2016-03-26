using UnityEngine;
using System.Collections;

public class Shooter_Controller : BaseClass {

	public Rigidbody2D bullet;
	public float speed = 20;

	void Start () {

	}

	// Fill In
	void Update ()
	{
		if (Input.GetKeyDown("space"))
		{
			ShootBullet (bullet,speed);
		}
	}

}
