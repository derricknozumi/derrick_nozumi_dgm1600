using UnityEngine;
using System.Collections;

public class Loops_passoff : MonoBehaviour
{
	void Start()
	{
	string[] strings = new string[4];

	strings [0] = "Bueller?";
	strings [1] = "Bueller???";
	strings [2] = "Is Bueller here";
	strings [3] = "Come on now Bueller....";

		foreach (string item in strings) {
			print (item);
		}
	}

}