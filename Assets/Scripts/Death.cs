using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Death : MonoBehaviour {

	public Slider HealthBar;
	public float Health;
	public Vector3 playerpos;
	// Use this for initialization
	void Start () {
	//	Health = 20000;
	}
	void update(){
		playerpos = this.transform.position;

	}


	void OnTriggerEnter (Collider other)
	{
		
		if (other.gameObject.tag == "zarm") {
			Debug.Log (Health); Health=Health-0.3f;
			HealthBar.value = Health;
			if (Health <= 0) {
				SceneManager.LoadScene ("Chapter1");
			}
		}
			if (other.gameObject.tag == "Exit") {
				SceneManager.LoadScene ("Chapter1");
			}
		}


	}

