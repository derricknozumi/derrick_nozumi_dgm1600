using UnityEngine;
using System.Collections;

public class Duck_Spawn : MonoBehaviour {
	public GameObject duck;

	void Start () 
	{
		Game_manager.OnSpawnDucks += SpawnDuck;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SpawnDuck()
	{
		Instantiate (duck, transform.position, Quaternion.identity);
	}
}
