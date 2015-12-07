using UnityEngine;
using System.Collections;

public class Dogcontrol : MonoBehaviour 
{
	Animator anim;
	
	void Start () {
		anim = GetComponent<Animator> ();
		Game_manager.OnDuckDeath += PlayDucks;
		Game_manager.OnDuckFlyAway += PlayLaugh;
	}
	

//	void Update () {
	
//	}
//}

	public void SpawnDucks()
	{
		Game_manager.OnSpawnDucks();
	}

	public void PlayLaugh()
	{
	anim.Play("Dog_Laugh_anim");
	}
	public void PlayDucks()
	          {
		anim.Play("DogDuckAnim");
	}
}

