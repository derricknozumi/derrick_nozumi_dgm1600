﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manage_Score : MonoBehaviour {
	
	public static int score;

	Text text;

	void Awake ()
	{
		text = GetComponent <Text>();

		score = 0;

	}

	void Update ()
	{
		text.text = "Score: " + score;
	}
}
