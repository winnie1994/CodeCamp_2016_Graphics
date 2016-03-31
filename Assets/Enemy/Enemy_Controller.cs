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

		string tag = GetTag(collision);

		if (tag == "MainCharacter"){
            EnemyHit(collision);
			Remove ();

		}if (tag == "Ground") {
            LoseLife();
            RunFunction("Ground", "Flash");
            RunFunction("MainCharacter", "Flash");
			SetColor (flash_color);
			RemoveAfterDelay(0.2f);
        }

    }
}
