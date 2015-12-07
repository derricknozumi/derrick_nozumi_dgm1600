using UnityEngine;
using System.Collections;

public class Gun_firing : MonoBehaviour {
	public Rigidbody Bullet;
	public Transform barrelEnd;
	
	
	void Update ()
	{
		if(Input.GetButtonDown("LeftMouse"))
		{
			Rigidbody rocketInstance;
			rocketInstance = Instantiate(Bullet, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
			rocketInstance.AddForce(barrelEnd.forward * 5000);
		}
	}
}