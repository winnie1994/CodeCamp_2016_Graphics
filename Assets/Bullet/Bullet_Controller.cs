using UnityEngine;
using System.Collections;

public class Bullet_Controller : BaseClass {
	public Color initial_color = new Color (1f, 0.75f, 0.9f, 1.0f);

	void Start () {
		SetColor (initial_color);
	}

	void Update () {
	
	}

	// Called when bullet hits something
	void OnCollisionEnter2D(Collision2D collision) {

		string tag = collision.gameObject.tag;

		if (tag == "Enemy") {
			collision.gameObject.SendMessage ("BulletCollided", GetColor());
			Scoreboard_Controller scoreboard = GetScoreboard ();
			scoreboard.AddToScore (10);
			Destroy (gameObject);

		}if (tag == "Bullet" || tag == "ColorBlock") {
			Color collider_color = collision.gameObject.GetComponent<SpriteRenderer> ().color;
			Color old_color = GetColor();
			Color new_color = MixColor(collider_color, old_color, 0.5f);
			SetColor(new_color);
		}
	}

	// Called when goes out of camera boundary
	void OnBecameInvisible() {
		Destroy (gameObject);
	}

}
