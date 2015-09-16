using UnityEngine;
using System.Collections;

public class if_statements : MonoBehaviour {

	// Use this for initialization
	void Start (){
	}
		float altitude = 30;
		float altitudeheightlimit= 50;
		float altitudedepthlimit = 10;
		
		
		void Update ()
		{
			if(Input.GetKeyDown(KeyCode.Space))
				AltitudeTest();
			
			altitude -= Time.deltaTime * 50;
		}
		
		
		void AltitudeTest ()
		{

			if(altitude > altitudeheightlimit)
			{

				print("You are too High.");
			}
	
			else if(altitude < altitudedepthlimit)
			{
			
				print("You are too low.");
			}

			else
			{
			
				print("Flight path Stable.");
			}
		}
}