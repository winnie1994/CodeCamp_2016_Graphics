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
		renderer.color = bullet_color;
		Destroy (gameObject, enemy_death_delay);
	}
}
