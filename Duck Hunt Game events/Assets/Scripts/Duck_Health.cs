using UnityEngine;
using System.Collections;

public class Duck_Health : MonoBehaviour 
{
	Animator anim;

	bool isInvincible;
	
		void Start ()
	{	
		anim = GetComponent<Animator> ();
		Game_manager.OnDuckMiss += MakeInvincible;
		Game_manager.OnDuckShot += MakeInvincible;

	}
	

	//void Update () {
	
	//}
	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "Killzone")
		{
			Destroy(this.gameObject);
			Game_manager.OnDuckDeath();
		}
		if (hit.tag == "Flyawayzone")
		{
			Game_manager.OnDuckFlyAway();
			Destroy (this.gameObject);
		}
	}
	public void KillDuck()
	{
		if (isInvincible == false) {
		anim.Play ("DuckDeath");
			Game_manager.OnDuckShot ();
		}
	}
	public void MakeInvincible()
		{
		isInvincible = true;
		}
	}	


