using UnityEngine;
using System.Collections;

public class ShootDuck : MonoBehaviour {
	RaycastHit hit;


	private Duck_Health refHealthDuck;

	public int bulletAmt;
	public int maxBullets;
	public GUI_script gui;

	public int bulletCount = 0;

	void Start ()
	{
		Game_manager.OnSpawnDucks += ResetBullets;
		bulletAmt = maxBullets;
		gui = GameObject.Find ("Canvas").GetComponent <GUI_script> ();

	}

	void Update () 
	{
	if (Input.GetMouseButtonDown (0))
		{
			bulletAmt --;

			if (bulletCount <3) 
			{
				bulletCount ++;
				gui.DisableBullet(bulletCount);
			}
				
				if(bulletAmt <=0)
			{
				Game_manager.OnDuckMiss();
			}
			Vector3 mousePos = Input.mousePosition;
			mousePos.z = Camera.main.transform.position.z;
			if(Physics.Raycast (Camera.main.ScreenToWorldPoint(mousePos),Camera.main.transform.forward, out hit, Mathf.Infinity))
			{
				if(hit.transform.tag =="Duck")
				{
					hit.transform.GetComponent<Duck_Health>().KillDuck();

				
			}
		}
	}
}
	public void ResetBullets()
	{
		bulletAmt = maxBullets;
	}
}