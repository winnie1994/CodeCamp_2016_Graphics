using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoreboard_Controller : MonoBehaviour {

	public int score;
	public int health;
	public int lives;

	public void Start ()
	{
		score = 0;
		UpdateScore ();
	}

	public void AddToScore(int amount)
	{
		score += amount;
		UpdateScore ();
	}

	public void UpdateScore ()
	{
		gameObject.GetComponent<Text>().text = "Score: " + score;
	}
}