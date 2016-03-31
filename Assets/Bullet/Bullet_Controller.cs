using UnityEngine;
using System.Collections;

public class Bullet_Controller : BaseClass {
	
	public Color flash_color;
    public Sprite flash_sprite;

	void Start () 
	{
	}

	// Called when bullet hits something
	void OnCollisionEnter2D(Collision2D collision) 
	{
		string tag = GetTag(collision);

		if (tag == "Enemy") {
            /*What do we need to do when we hit an enemy?*/
            Kill(collision);
            AddToScore(10);
            SetColor(flash_color);
            RemoveAfterDelay(0.1f);
		}
       
    }

	// Called when goes out of camera boundary
	void OnBecameInvisible() 
	{
		Remove();
	}

}
