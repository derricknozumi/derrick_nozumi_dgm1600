using UnityEngine;
using System.Collections;

public class Switch_statements : MonoBehaviour 
{
/* 
switch statements are a streamlined way of selecting certain variables from a list based on one inputed variable given the 
int is declared and it searches the switch statement to find which variable has the same case number as the input variable.
*/

	public int superPower = 5;
	

	void Start () 
	{

		switch (superPower)
		{
			case 5:
			print ("Telekinesis");
				break;
			case 4:
			print ("Super Strength");
				break;
			case 3:
			print ("Pyrokinesis");
				break;
			case 2:
			print ("Invisibility");
				break;
			case 1:
			print ("Regeneration");
				break;
		default:
			print ("Normal boring old Human");
				break;
			}
		}
	}
