using UnityEngine;
using System.Collections;

public class Duck_movement : MonoBehaviour {
	public float speed;
	public Vector3 direction;

	public int bounce;
	public int bounceMax;

	void Start () {
		Game_manager.OnDuckShot += StopMovement;
		Game_manager.OnDuckMiss += flyAway;
		RandomDirection ();
	}
	

	void FixedUpdate () 
	{
		transform.position = transform.position + (direction * speed);
	}
	public void RandomDirection()
	{
		direction = new Vector3 (Random.Range (-1f, 1f), Random.Range (.2f, .5f), 0); 
	}
	public void DirectionChanger(Vector3 _dir)
	{
		direction = new Vector3(direction.x * _dir.x, direction.y * _dir.y);

		bounce++;

		if (bounce >= bounceMax) {
			direction = new Vector3 (0, 1, 0);
			Game_manager.OnDuckMiss();
		}
	}
	public void StopMovement()
	{
		direction = new Vector3 (0, 0, 0);
	}
	public void Startfall()
	{
		direction = new Vector3 (0, -1, 0);
	}
	public void flyAway()
	{
		direction = new Vector3 (0, 1, 0);
	}

}
