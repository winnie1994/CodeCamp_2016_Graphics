using UnityEngine;
using System.Collections;

public class Enemy1_Controller : BaseClass {

	void Start () {
	
	}

	void Update () {
	
	}

	void BulletCollided(Color bullet_color){
		SetColor (Color.yellow);
		Destroy (gameObject, 0.1f);
	}
		
	void OnCollisionEnter2D(Collision2D collision) {

		string tag = collision.gameObject.tag;

		if (tag == "MainCharacter"){
			collision.gameObject.SendMessage ("EnemyCollided");
			Destroy (gameObject,0f);

		}if (tag == "Ground") {
			SetColor (Color.red);
			Destroy (gameObject,0.1f);
		}

	}
}
