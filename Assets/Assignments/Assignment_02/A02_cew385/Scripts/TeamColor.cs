using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace A02_cew385
{
    public class TeamColor : MonoBehaviour
    {

        public Color teamColor = Color.blue;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            // Allow the user to control team colors
            this.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = teamColor;
            this.transform.GetChild(1).GetComponent<MeshRenderer>().material.color = teamColor;
            this.transform.GetChild(2).GetComponent<MeshRenderer>().material.color = teamColor;
        }
    }
}