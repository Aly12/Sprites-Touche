using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPointBehavior : MonoBehaviour {

	public Vector2 destination;
	public Vector2 location;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		location = gameObject.transform.position;
		destination = Camera.main.ScreenToWorldPoint (Input.mousePosition);

		if (Input.GetMouseButtonDown (1) && location == destination) 
		{
			Debug.Log ("Pressed right button...");
			gameObject.SetActive(false);


		}
		
	}
}
