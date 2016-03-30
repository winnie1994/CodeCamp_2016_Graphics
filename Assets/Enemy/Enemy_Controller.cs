using UnityEngine;
using System.Collections;

public class Enemy_Controller : BaseClass {

    public Color initial_color;
    public Color color_on_hit_ground;

    void Start()
    {
        SetColor(initial_color);
    }

    void Update () 
	{
	
	}

	void HitByBullet()
	{
		SetColor (Color.yellow);
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
			GameObject.FindWithTag("MainCharacter").SendMessage("ChangeDisplayOnEnemyHit");
			SetColor (color_on_hit_ground);
			RemoveAfterDelay(0.1f);
        }

    }
}
