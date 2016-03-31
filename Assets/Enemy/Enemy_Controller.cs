using UnityEngine;
using System.Collections;

public class Enemy_Controller : BaseClass {

    public Color flash_color;

    void Start()
    {
    }

    void Update () 
	{
	
	}

	void HitByBullet()
	{
		SetColor (flash_color);
		RemoveAfterDelay(0.1f);
	}
		
	void OnCollisionEnter2D(Collision2D collision) 
	{

		string tag = collision.gameObject.tag;

		if (tag == "MainCharacter"){
            EnemyHit(collision);
			Remove ();

		}if (tag == "Ground") {
            EnemyHit(collision);
            RunFunction("MainCharacter", "Flash");
			SetColor (flash_color);
			RemoveAfterDelay(0.1f);
        }

    }
}
