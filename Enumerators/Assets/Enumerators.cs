using UnityEngine;
using System.Collections;

public class Enumerators : MonoBehaviour 
{

	enum Direction {North, East, South, West};
	
	void Start () 
	{
		Direction myDirection;
		
		myDirection = Direction.North;
	}
	
	Direction ReverseDirection (Direction dir)
	{
		if(dir == Direction.North)
			dir = Direction.South;
		else if (dir == Direction.South)
			dir = Direction.North;
		else if (dir == Direction.East)
			dir = Direction.West;
		else if (dir == Direction.West)
			dir = Direction.East;
		
		return dir;
	}
}








/* Enumerators are an assignment of Value to a variable to allow for equal and convenient access
  How to Declare an Enum {North, East, etc, etc,};

 * Assigning values to Constants {North = 1, East = 5, South = 10, West = 20};

 * changing the type of an enum enum Direction : short {North, East, etc, etc}; (for optimization)

 * creating an enum variable and assigning values to it 
		Direction myDirection;
		myDirection = Direction.North;

 * passing and returning enum from a function 
Direction ReverseDirection (Direction dir)
	if (dir == Direction.North)
		dir = Direction.South;
	else if(dir == Direction.South)
		dir = Direction.North;




*/













