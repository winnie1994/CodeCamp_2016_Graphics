using UnityEngine;
using System.Collections;

public class Shooter_Controller : BaseClass {

	public Rigidbody2D bullet;
	public float speed = 10;

	void Start () {

	}

	// Fill In
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
            print("SPACE");
			ShootBullet (bullet,speed);
		}
	}

}
