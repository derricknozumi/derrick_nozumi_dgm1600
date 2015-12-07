using UnityEngine;
using System.Collections;

public class Direction_Changer : MonoBehaviour {

	public enum Changer{ Horizontal, Vertical};
	public Changer changer;

	bool Gameobject;

	void Start()
	{
		Game_manager.OnDuckShot += TurnOff;
		Game_manager.OnDuckMiss += TurnOff;
		Game_manager.OnSpawnDucks += TurnOn;
	}
	void OnCollisionEnter(Collision hit)
	{
	Duck_movement movement = hit.gameObject.GetComponent<Duck_movement>();
	if(hit.transform.tag == "Duck")
	{
		if(changer == Changer.Horizontal)
		{
				movement.DirectionChanger(new Vector3(-1,1,0));
		}
		else if (changer == Changer.Vertical)
		{
				movement.DirectionChanger(new Vector3(1,-1,0));
		}
	 }

   }
	public void TurnOff()
	{
		gameObject.SetActive (false);
	}
	public void TurnOn()
	{
		gameObject.SetActive (true);
	}
}
