using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CallHeli : MonoBehaviour {

	public GameObject heli;

	GameObject tempprojectile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "bullet") {
			

		}
	}
}
