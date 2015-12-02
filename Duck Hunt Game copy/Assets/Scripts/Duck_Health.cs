using UnityEngine;
using System.Collections;

public class Duck_Health : MonoBehaviour {



	/*	void Start () {	
	}
	

	void Update () {
	
	}*/
	void OnTriggerEnter(Collider hit)
	{
		if (hit.tag == "Killzone")
		{
			Destroy(this.gameObject);
		}
	}
}
