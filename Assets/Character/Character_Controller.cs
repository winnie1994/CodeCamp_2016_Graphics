using UnityEngine;
using System.Collections;

public class Character_Controller : BaseClass {

    //These are the parameters for character movement!
	public float horizontal_speed = 0.1f;
    //Character starts here
	public float initial_position = 0f;

    //These are the boundary/limits to where our character may move
	public float right_boundary = 6f;
	public float left_boundary = -6f;

    //This is the bullet we'll be shooting
	public Rigidbody2D bullet;
    //This is our bullet speed
	public float bullet_speed = 20;

    public Color flash_color;
	public Sprite flash_sprite;

	private float position;


	void Start () 
	{
        SetEnemySpeedRange(1, 3);
		MoveTo (initial_position);
	}
	
	void Update () 
	{
        /*What happens when we press controls? We need to move and shoot. Write this code!*/
		if (Input.GetKey ("right")) MoveRight ();
    }

	void HitByEnemy()
	{
        /*What happens when we hit an enemy?*/
        /*We lose a life*/
        LoseLife();
        /*We flash our character*/
        Flash();
        /*We move to our starting position*/
        //position = initial_position;
        //MoveTo(position);
    }

	void MoveRight() 
	{
        /*How can we move to the right? Hint: Look at the EnemyCollided code :) */
    }

	void MoveLeft() 
	{
        /*How can we move to the left? Hint: Look at the EnemyCollided code :) */
    }

    void Flash()
    {
        SetTemporaryColor(flash_color, 0.2f);
        SetTemporarySprite(flash_sprite,0.2f);
    }

}
