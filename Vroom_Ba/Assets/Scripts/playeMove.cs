using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeMove : MonoBehaviour {

	public float speedX = 10;
	public float speedY = 10;
	public Rigidbody2D rb;
	public Vector2 destination;
	public Vector2 place;
	public Vector2 journey;
	public Vector2 gap;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		place = rb.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			destination = Camera.main.ScreenToWorldPoint (Input.mousePosition);

			journey.x = destination.x - place.x;
			journey.y = destination.y - place.y;
			rb.velocity = new Vector2 (journey.normalized.x * speedX * Time.deltaTime, journey.normalized.y * speedY * Time.deltaTime);
		}
		
	}

	void LateUpdate(){

		place = rb.transform.position;
		gap.x = Mathf.Abs (destination.x) - Mathf.Abs (place.x);
		gap.y = Mathf.Abs (destination.y) - Mathf.Abs (place.y);

		if (.05 > Mathf.Abs (gap.x))
		if (.05 > Mathf.Abs (gap.y))
			rb.velocity = new Vector2 (0, 0);
	


	}
}
