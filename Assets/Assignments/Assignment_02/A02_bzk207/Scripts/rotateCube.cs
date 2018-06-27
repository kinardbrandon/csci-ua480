using UnityEngine;
using System.Collections;

public class rotateCube : MonoBehaviour {
	
	
	public float x = 0.0f;
	public float y = 1.5f;
	public float z = 0.0f;
	
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	
	
	// Update is called once per frame
	void Update () {
		//f is for float unity understands as float. parameters are how much the
		//object will move per frame (x, y ,z)
		transform.Rotate(x, y, z);
		
	}
}
