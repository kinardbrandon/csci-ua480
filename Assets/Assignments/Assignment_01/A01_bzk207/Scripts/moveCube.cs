using UnityEngine;
using System.Collections;

public class moveCube: MonoBehaviour {
	
	
	public float x = -0.5f;
	public float y = 0.0f;
	public float z = 0.0f;
	

	// Use this for initialization
	void Start () {
		
	}
	
	
	
	// Update is called once per frame
	void Update () {
		//f is for float unity understands as float. parameters are how much the
		//object will move per frame (x, y ,z)
		transform.Translate (x, y, z);
		
	}
}
