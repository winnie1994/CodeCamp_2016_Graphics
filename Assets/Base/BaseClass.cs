using UnityEngine;
using System.Collections;

public class BaseClass : MonoBehaviour {

	public void SetColor(Color color){
		SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
		if(renderer != null)renderer.color = color;	
	}

	public Color GetColor(){
		SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
		if(renderer!= null)return renderer.color;
		return Color.white;
	}

	public Color MixColor(Color color1, Color color2, float weight){
		Color new_color = Color.Lerp (color1, color2, weight);
		new_color.a = 1f;
		return new_color;
	}

	public void Rotate(float x){
		transform.Rotate (0f, 0f, x);
	}

	public void RotateTo(float x){
		transform.rotation = Quaternion.identity;
		transform.Rotate (0f, 0f, x);
	}

	public void MoveTo(float x){
		Vector2 new_position = transform.position;
		new_position.x = x;
		transform.position = new_position;
	}

	public void ShootBullet(Rigidbody2D bullet, float velocity)
	{
		Rigidbody2D instantiated_bullet = Instantiate(bullet,transform.position, transform.rotation) as Rigidbody2D;
		instantiated_bullet.GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(new Vector2(0,velocity));
		Physics2D.IgnoreCollision(instantiated_bullet.GetComponent<Collider2D>(),gameObject.GetComponent<Collider2D>());

	}

	public Scoreboard_Controller GetScoreboard(){
		Scoreboard_Controller scoreboard = GameObject.Find("GameController_Object").GetComponent<Scoreboard_Controller>();
		return scoreboard;
	}
	
}
