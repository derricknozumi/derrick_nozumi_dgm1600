using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
	//	int[] myIntArray = {6, 24, 36, 59, 79};
	//int[] myIntArraytwo = new int[5];
	public GameObject[] cubes;
	void Start () {
	/*	myIntArraytwo [0] = 6;
		myIntArraytwo [1] = 24;
		myIntArraytwo [2] = 36;
		myIntArraytwo [3] = 59;
		myIntArraytwo [4] = 79;
*/
		cubes = GameObject.FindGameObjectsWithTag ("Cubes");

		for(int i = 0; i < cubes.Length; i++)
		{
			Debug.Log ("Cube Number" +i+" is named" +cubes[i].name);
 	
	
	}
	
	}
}
