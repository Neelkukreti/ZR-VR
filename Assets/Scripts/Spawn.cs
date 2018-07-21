using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject zomba;
	public GameObject player;
	public int znum1;

	// Use this for initialization
	void Start () {
		znum1 = 0;

	}

	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter (Collider other)
	{

		if (other.gameObject.tag == "Player") {

			Debug.Log ("yeah");
			SpawnAgent ();

		}
	}

	void SpawnAgent ()
	{
		
		if (Vector3.Distance (player.transform.position, this.transform.position) < 20 && znum1<20) {
			for (int i = 0; i < 2; i++) {


				znum1 += 3;

				Debug.Log ("yeah");

			//	GameObject bu = Instantiate(Resources.Load("zombie") as GameObject);
				GameObject na = (GameObject)Instantiate (zomba, this.transform.position, Quaternion.identity);

			}
		}
	}
}
