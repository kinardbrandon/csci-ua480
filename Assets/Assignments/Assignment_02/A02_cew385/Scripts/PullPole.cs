using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace A02_cew385
{
    public class PullPole : MonoBehaviour
    {
        public KeyCode key = KeyCode.N;
        // Use this for initialization
        void Start()
        {
         
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            // Use a key to change the rotation of the foosball pole
            if(Input.GetKey(key)){
                this.transform.Rotate(Vector3.forward*Time.deltaTime);
            }
        }
    }
}