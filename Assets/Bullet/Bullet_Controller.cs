using UnityEngine;
using System.Collections;

public class Bullet_Controller : MonoBehaviour {

	private SpriteRenderer renderer;

	void Start () {
		renderer = gameObject.GetComponent<SpriteRenderer> ();
		Color initial_color = new Color (0.9f, 0.85f, 0.9f, 1.0f);
		renderer.color = initial_color;
	}

	void Update () {
	
	}
	// Called when goes out of camera boundary
	void OnBecameInvisible() {
		//Remove object from game
		Destroy (gameObject);
	}

	// Called when bullet hits something
	void OnCollisionEnter2D(Collision2D collision) {

		//See what type of object it hits
		string tag = collision.gameObject.tag;

		if (tag == "MainCharacter")return;
		if (tag == "Enemy") {
			Scoreboard_Controller scoreboard = GameObject.Find("GameController_Object").GetComponent<Scoreboard_Controller>();
			scoreboard.AddToScore (10);
			collision.gameObject.SendMessage ("BulletHit", renderer.color);
			Destroy (gameObject);

		}if (tag == "Bullet" || tag == "ColorBlock") {
			Color collider_color = collision.gameObject.GetComponent<SpriteRenderer> ().color;
			Color old_color = renderer.color;
			Color new_color = Color.Lerp (old_color, collider_color, 0.5f);
			new_color.a = 0.98f;
			renderer.color = new_color;
		}

	}
}
