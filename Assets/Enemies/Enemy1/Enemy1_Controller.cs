using UnityEngine;
using System.Collections;

public class Enemy1_Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void BulletHit(Color bullet_color){
		SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer> ();
		renderer.color = bullet_color;
		Destroy (gameObject, 0.6f);
	}
}
