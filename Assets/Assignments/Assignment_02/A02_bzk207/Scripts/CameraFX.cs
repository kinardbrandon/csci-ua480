using UnityEngine;
using System.Collections;

public class CameraFX : MonoBehaviour {

	public float sH = 6.0f;
	public float sV = 6.0f;
	
	private float y = 0.0f;
	private float p = 0.0f;

	// Use this for initialization
	void Start()
	{
		
	}
	
	// Update is called once per frame
	void Update()
	{
		
		y += sH * Input.GetAxis("Mouse X");
		p -= sV * Input.GetAxis("Mouse Y");
		
		transform.eulerAngles = new Vector3(p, y, 0.0f);



		
	}
}

