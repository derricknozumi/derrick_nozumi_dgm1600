using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour 
{
		int myInt = 35;
	//myInt is the variable that you will enter in as the numerical value that you want entered into the program string
	
	// Use this for initialization
	void Start () {
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	}
	int MultiplyByTwo(int number){
		int ret;

		ret = number * 2;

		return ret;
	}
}
	