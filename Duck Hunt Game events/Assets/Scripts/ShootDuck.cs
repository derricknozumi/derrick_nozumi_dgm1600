using UnityEngine;
using System.Collections;

public class ShootDuck : MonoBehaviour {
	RaycastHit hit;

	private Duck_Health refHealthDuck;

	public int bulletAmt;
	public int maxBullets;
	//public GUI_script
	//You will have a oyblic gameobject in which you assign the guimanager in the inspector
	//private 


	void Start ()
	{
		Game_manager.OnSpawnDucks += ResetBullets;
		bulletAmt = maxBullets;

	// use get component
	}
	
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetMouseButtonDown (0))
		{
			bulletAmt --;
				
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