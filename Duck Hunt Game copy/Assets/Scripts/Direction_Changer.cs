using UnityEngine;
using System.Collections;

public class Direction_Changer : MonoBehaviour {

	public enum Changer{ Horizontal, Vertical};
	public Changer changer;

	void OnCollisionEnter(Collision hit)
	{
	Duck_movement  movement = hit.gameObject.GetComponent<Duck_movement>();
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

}
