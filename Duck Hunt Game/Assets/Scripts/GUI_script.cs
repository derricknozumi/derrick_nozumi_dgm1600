using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUI_script : MonoBehaviour {

	public Image[] bullets;

	void Start () 
	{
	Game_manager.OnSpawnDucks += ResetBullets;
	}
	
	public void DisableBullet(int Index)
	{
		bullets[Index - 1].enabled = false;
	}
		void ResetBullets()
	{
		foreach(Image bul in bullets)
			{
					bul.enabled = true;
			Camera.main.GetComponent<ShootDuck>().bulletCount = 0;
		}
	}
}
