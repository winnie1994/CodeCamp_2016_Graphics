using UnityEngine;
using System.Collections;

public class Bullet_Controller : BaseClass {
	
	public Color flash_color;

	void Start () 
	{
	}

	// Called when bullet hits something
	void OnCollisionEnter2D(Collision2D collision) 
	{
		string tag = GetTag(collision);

		if (tag == "Enemy") {
            /*What do we need to do when we hit an enemy?*/
            SetTemporaryColor(flash_color, 0.2f);
            Kill(collision);
            AddToScore(10);
            RemoveAfterDelay(0.2f);
		}
       
    }

	// Called when goes out of camera boundary
	void OnBecameInvisible() 
	{
		Remove();
	}

}
