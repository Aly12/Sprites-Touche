using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Move_Vroomba : MonoBehaviour
{
	//attached to Vroomba GO

	public Text coordinateData;
	public float goSpeed;
	private Vector2 touchOrigin = -Vector2.one; //starts origin off screen
	public Rigidbody2D rb2D;

	private void Awake()
	{
		rb2D = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		if (Input.touchCount == 0)
		{
			rb2D.velocity = Vector2.zero;
		}

		if (Input.touchCount > 0)
		{

			Touch myTouch = Input.touches[0];


			if (myTouch.phase == TouchPhase.Began || myTouch.phase == TouchPhase.Moved || myTouch.phase == TouchPhase.Stationary)
			{
				touchOrigin = myTouch.position;
				coordinateData.text = "x value is: " + touchOrigin.x.ToString() + "\ny value is: " + touchOrigin.y.ToString();

				Move();
			}
		}
	}

	private void Move()
	{
		if (touchOrigin.x < 1722 && touchOrigin.x > 1516)  //270 
		{
			rb2D.AddForce(-transform.right * goSpeed);
		}

		else if (touchOrigin.x > 1770 && touchOrigin.x < 1915.23)  //090
		{
			rb2D.AddForce(transform.right* goSpeed);
		}
		else if (touchOrigin.y > 192 && touchOrigin.y < 365)  //000
		{
			rb2D.AddForce(transform.up * goSpeed);
		}
		else if (touchOrigin.y < 164 && touchOrigin.y > 25)  //090
		{
			rb2D.AddForce(-transform.up * goSpeed);

		}
	}
}
