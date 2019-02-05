using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCast : MonoBehaviour
{
	//attached to empty GO

	public Text rayCastData;
	public Rigidbody2D rb2D;
	public float goSpeed = 3;

	public void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}


	void Update()
	{
		if (Input.touchCount == 0)//if no touches, also if pick up finger, vroomba to zero
		{
			rb2D.velocity = Vector2.zero;
		}

		if (Input.touchCount > 0)
		{

			Vector2 origin = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
			RaycastHit2D hit = Physics2D.Raycast(origin, (Input.GetTouch(0).position));

			if (hit.collider)
			{

				rayCastData.text = "rayCastData hit name is:   " + hit.collider.gameObject.name;
				if (hit.collider.gameObject.name == "northCollider")
				{
					rb2D.AddForce(transform.up * 3);
				}
				else if (hit.collider.gameObject.name == "southCollider")
				{
					rb2D.AddForce(-transform.up * 3);
				}
				else if (hit.collider.gameObject.name == "eastCollider")
				{
					rb2D.AddForce(transform.right * 3);
				}
				else if (hit.collider.gameObject.name == "westCollider")
				{
					rb2D.AddForce(-transform.right * 3);
				}
				else if (hit.collider.gameObject.name == "centerCollider")
				{
					rb2D.velocity = Vector2.zero;
				}

				else
				{
					rayCastData.text = "hitting no colliders";
				}
			}
		}
	}
}
