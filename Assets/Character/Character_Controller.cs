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

    //These are colors we use
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
		if (Input.GetKey ("right") && position < right_boundary) MoveRight ();
		if (Input.GetKey ("left") && position > left_boundary) MoveLeft ();
        if (Input.GetKeyDown("space")) ShootBullet(bullet, bullet_speed);
    }

	void HitByEnemy()
	{
        /*What happens when we hit an enemy?*/
        /*We lose a life*/
        LoseLife();
        /*We flash magenta for half a second*/
        Flash();
        /*We move to our starting position*/
        //position = initial_position;
        //MoveTo(position);
    }
		
	void MoveRight() 
	{
        /*How can we move to the right? Hint: Look at the EnemyCollided code :) */
        position += horizontal_speed;
        MoveTo(position);
    }

	void MoveLeft() 
	{
        /*How can we move to the left? Hint: Look at the EnemyCollided code :) */
        position -= horizontal_speed;
        MoveTo(position);
    }

    void Flash()
    {
        SetTemporaryColor(flash_color, 0.5f);
        SetTemporarySprite(flash_sprite, 0.5f);

    }

}
