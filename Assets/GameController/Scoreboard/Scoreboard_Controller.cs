using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Scoreboard_Controller : MonoBehaviour {

	public int score;
	public int health;
	public int lives;


	public void Start ()
	{
		score = 0;
		UpdateScore ();
		UpdateLives ();
	}

	public void AddToScore(int amount)
	{
		score += amount;
		UpdateScore ();
	}
		
	public void UpdateScore ()
	{
		GameObject.Find("Score").GetComponent<Text>().text = "Score: " + score;
	}

	public void LoseLife()
	{
		lives--;
		UpdateLives ();
        if (lives <= 0) SceneManager.LoadScene("GameOver");
	}

	public void GainLife()
	{
		lives++;
		UpdateLives ();
	}

	public void UpdateLives ()
	{
		GameObject.Find("Lives").GetComponent<Text>().text = "Lives: " + lives;
	}

}