using UnityEngine;
using System.Collections;

public class Duck_Health : MonoBehaviour 
{
	Animator anim;
	public int scoreValue = 100;
	bool isInvincible;
	public DuckUI dUI;
	
		void Start ()
	{	
		anim = GetComponent<Animator> ();
		Game_manager.OnDuckMiss += MakeInvincible;
		Game_manager.OnDuckShot += MakeInvincible;
		dUI = GameObject.Find ("GameManager").GetComponent <DuckUI> ();
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
			Manage_Score.score += scoreValue;

			dUI.UpdateDucks();
		}
	}

	void ChangeTexture (int duckNum){

	}

	public void MakeInvincible()
		{
		isInvincible = true;
		}
	}	


