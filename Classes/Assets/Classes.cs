using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour {


	public class Resources
	{
		public int gold;
		public int wood;
		public int food;

		public Resources(int gol, int woo, int foo)
		{
			gol = 5000;
			gold = gol;
			wood = woo;
			food = foo;
		}
	}


		public Resources baseResources = new Resources(200, 500, 900);






	void Start () {
		
		Debug.Log (baseResources.food);

		int first = 10;
		int second = first;
		second = 100;

		Resources newResources = baseResources;
		newResources.food = 0;

		Transform trans1 = transform;
		Transform trans2 = trans1;
	}
}

