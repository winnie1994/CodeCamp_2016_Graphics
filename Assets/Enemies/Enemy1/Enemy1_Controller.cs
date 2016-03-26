using UnityEngine;
using System.Collections;

public class Enemy1_Controller : MonoBehaviour {

	public float enemy_death_delay = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void BulletHit(Color bullet_color){
		SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
		renderer.color = Color.yellow;
		Destroy (gameObject, 0.1f);
	}

	// Called when enemy hits something
	void OnCollisionEnter2D(Collision2D collision) {

		//See what type of object it hits
		string tag = collision.gameObject.tag;
		if (tag == "MainCharacter"){
			collision.gameObject.SendMessage ("EnemyHit");
			Destroy (gameObject);

		}if (tag == "Ground") {
			SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
			renderer.color = Color.red;
			Destroy (gameObject,0.1f);
		}

	}

}
