using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 

 {
	int numCars = 6;

	void Start () 
	{
		for(int i = 0; i < numCars; i++)
		{
			Debug.Log("Creating Additional Transport: "+i);
	}
	}
}

/*
//---------------------------------

{
	int choresToDo = 8;	

	void Start ()
	{
		while(choresToDo > 0)
		{
			Debug.Log ("I've finished a Chore");
			choresToDo--;
	}
	}
}
*/



	//----------------------------
/*
{
	

	void Start () {
		bool shouldContinue = false;

		do 
		{
					print ("All your base are belong to us");
				} while(shouldContinue == true);
	}
}




*/


	// -----------------------
/*
{
	void Start () 
{
		string[] strings = new string[4];

		strings [0] = "Bueller?";
		strings [1] = "Bueller???";
		strings [2] = "Is Bueller here";
		strings [3] = "Come on now Bueller....";

		foreach(string item in strings)
		{
			print (item);

	}
	}
}

*/

