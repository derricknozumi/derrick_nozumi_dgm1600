using UnityEngine;
using System.Collections;

public class Game_manager : MonoBehaviour 
{
	public delegate void DuckDel();
	public static DuckDel OnSpawnDucks;
	public static DuckDel OnDuckShot;
	public static DuckDel OnDuckDeath;
	public static DuckDel OnDuckFlyAway;
	public static DuckDel OnDuckMiss;


}
