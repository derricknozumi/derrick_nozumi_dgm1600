using UnityEngine;
using System.Collections;

public class Pass_off : MonoBehaviour
{
	int MyFun = 25;
	// Use this for initialization
	void Start () {
	
		MyFun = MultiplyByFour (MyFun);
		Debug.Log (MyFun);
	}
		int MultiplyByFour (int number){
			int ret;
			                       
			ret = number * 4;

			return ret;
	
	}
}
