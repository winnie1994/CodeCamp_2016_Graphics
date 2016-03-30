using UnityEngine;
using System.Collections;

public class Enemy_Controller : BaseClass {

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}

	void BulletCollided()
	{
		SetColor (Color.yellow);
		RemoveAfterDelay(0.1f);
	}
		
	void OnCollisionEnter2D(Collision2D collision) 
	{

		string tag = collision.gameObject.tag;

		if (tag == "MainCharacter"){
			collision.gameObject.SendMessage ("EnemyCollided");
			Remove ();

		}if (tag == "Ground") {
			SetColor (Color.red);
			RemoveAfterDelay(0.1f);
		}

	}
}
