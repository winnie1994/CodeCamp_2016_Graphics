using UnityEngine;
using System.Collections;

public class Bullet_Controller : BaseClass {
	
	public Color initial_color;

	void Start () 
	{
		SetColor (initial_color);
	}

	// Called when bullet hits something
	void OnCollisionEnter2D(Collision2D collision) 
	{
		string tag = GetTag(collision);

		if (tag == "Enemy") {
            /*What do we need to do when we hit an enemy?*/
            Kill(collision);
            AddToScore(10);
            Remove();
		}
       
    }

	// Called when goes out of camera boundary
	void OnBecameInvisible() 
	{
		Remove();
	}

}
