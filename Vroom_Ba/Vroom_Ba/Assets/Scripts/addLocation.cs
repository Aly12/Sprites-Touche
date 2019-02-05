using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Analytics;

public class addLocation : MonoBehaviour {

	public GameObject waypoint;
	public Vector2 destination;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Debug.Log ("pressed left button.");
			destination = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			//destination.z = 0.0f;
			Debug.Log (destination);
			Instantiate (waypoint, destination, Quaternion.Euler(new Vector2(0,0)));
		}
			
		
	}
}
