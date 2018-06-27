using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public float moveSpeed = 30000f; //ballspeed
	//detetc rigidbody
	private Rigidbody body;
	private bool visible = false;
	
	// when visible by camera
	void OnBecameVisible()
	{
		visible = true;
	}
	
	//when not visible
	void OnBecameInvisible()
	{
		visible = false;
	}


	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

				if (visible == true) {

						//detect 
						float iX = Input.GetAxis ("Horizontal");
						float iZ = Input.GetAxis ("Vertical");

						float mX = iX * moveSpeed * Time.deltaTime;
						float mZ = iZ * moveSpeed * Time.deltaTime;
	
						//move ball
				
						body.AddForce (mX, 0f, mZ);
				}
		}
}
