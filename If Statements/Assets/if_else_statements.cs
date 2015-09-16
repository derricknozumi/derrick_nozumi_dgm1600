using UnityEngine;
using System.Collections;

public class if_else_statements : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	float altitude = 200;
	float altitudeheightlimit= 100;
	float altitudedepthlimit = 50;
	
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			AltitudeTest();
		
		altitude -= Time.deltaTime * 50;
	}
	
	
	void AltitudeTest ()
	{
	if (altitude > altitudeheightlimit)
		{
			print ("you are too High");
	}
	else if(altitude < altitudedepthlimit)
	{
		print ("you are too low");
}
		else 
		{
			print ("you are flying stable");
		}
	}
}
