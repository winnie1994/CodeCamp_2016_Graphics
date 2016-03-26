using UnityEngine;
using System.Collections;

public class EnemySpawner_Level1 : MonoBehaviour {
	public Rigidbody2D enemy;
	public Vector2 spawn_range;
	public int enemy_count;
	public float spawn_interval;
	public float start_delay;
	public float wave_interval;
	public bool trigger_next_wave;
	void Start ()
	{
		trigger_next_wave = false;
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (start_delay);
		while (true)
		{
			for (int i = 0; i < enemy_count; ++i)
			{
				Vector2 spawn_position = new Vector2 (Random.Range (-spawn_range.x, spawn_range.x), Random.Range (0.5f*(spawn_range.y), spawn_range.y));
				Quaternion spawn_rotation = Quaternion.AngleAxis(Random.Range(0,360), Vector3.forward);

                Rigidbody2D instantiated_enemy = Instantiate (enemy, spawn_position,spawn_rotation) as Rigidbody2D;
                instantiated_enemy.velocity = transform.TransformDirection(new Vector2(0, -1));

                yield return new WaitForSeconds (spawn_interval);
			}
			yield return new WaitForSeconds (wave_interval);
		}
	}
}
