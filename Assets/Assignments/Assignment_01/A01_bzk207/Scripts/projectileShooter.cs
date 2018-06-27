using UnityEngine;
using System.Collections;

public class projectileShooter : MonoBehaviour {


	GameObject proj;
	// Use this for initialization
	void Start () {
		proj = Resources.Load ("projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){

			GameObject projectice = Instantiate(proj) as GameObject;

			projectice.transform.position = transform.position+Camera.main.transform.forward * 2;

			Rigidbody body = projectice.GetComponent<Rigidbody>();

			body.velocity= Camera.main.transform.forward * 300;
	
	}
}

}
