using UnityEngine;
using System.Collections;

public class GUI_script : MonoBehaviour {
	public GameObject[] bullets;


	void Start () 
	{
	Game_manager.OnSpawnDucks = ResetBullets;
	}
	
	public void DisableBullet(int Index)
	{
		bullets[Index].SetActive(false);
	}
		void ResetBullets()
	{
		foreach(GameObject bul in bullets)
			{
					bul.SetActive(true);
		}
	}
}
