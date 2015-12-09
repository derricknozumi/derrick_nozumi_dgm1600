using UnityEngine;
using System.Collections;

public class Duck_Spawn : MonoBehaviour {
	public GameObject duck;
	DuckUI dUI;

	void Start () 
	{
		dUI = GameObject.Find ("GameManager").GetComponent <DuckUI> ();
		Game_manager.OnSpawnDucks += SpawnDuck;
	}

	void Update () {
	
	}
	public void SpawnDuck()
	{
		Instantiate (duck, transform.position, Quaternion.identity);
		dUI.duckCount ++;
	}
}
