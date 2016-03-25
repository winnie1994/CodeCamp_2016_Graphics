using UnityEngine;
using System.Collections;

public class Shooter_Controller : MonoBehaviour {

	public Rigidbody2D bullet;
	public float speed = 20;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Rigidbody2D instantiated_bullet = Instantiate(bullet,transform.position, transform.rotation) as Rigidbody2D;
			instantiated_bullet.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(new Vector2(0,speed));
			Physics2D.IgnoreCollision(instantiated_bullet.GetComponent<Collider2D>(),gameObject.GetComponent<Collider2D>());
		}
	}
}
