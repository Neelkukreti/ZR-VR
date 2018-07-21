using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

	public UnityEngine.AI.NavMeshAgent agent;
	public float destroydist_ ;
	public Animator animatorController;
	public GameObject player;
	public float p,zspeed;
	public float followDist;
	public Vector3 offset;
	public int zombieHealth;

	// Use this for initialization
	void Start () {

		//zombieHealth = 1;
		if(player==null)
			player=GameObject.FindGameObjectWithTag("Player");
		if (animatorController == null)
			animatorController = GetComponent<Animator> ();
		agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
	
	}
	IEnumerator dest()
	{
		yield return new WaitForSeconds(3);

		Destroy(gameObject);
	}
	// Update is called once per frame
	void Update () {

	
		//Script to destroy zombie when distance is v high

		if(Vector3.Distance(player.transform.position, this.transform.position)> destroydist_){

			Destroy (this.gameObject);
		}

		if (Vector3.Distance (player.transform.position, this.transform.position) < followDist) {
		


			Vector3 direction = player.transform.position - this.transform.position;
			direction.y = 0f;
			this.transform.rotation=Quaternion.Slerp(this.transform.rotation,Quaternion.LookRotation(direction),0.1f);
			if (Vector3.Distance (player.transform.position, this.transform.position) >1) {
	//			this.transform.Translate (0, 0, zspeed);
	//		}
				agent.SetDestination(player.transform.position-offset);}
		}

		if (zombieHealth <= 0) {
			animatorController.Play ("death");
			//yield return new WaitForSeconds(5);
			StartCoroutine("dest");
		}
		else
		if (Vector3.Distance (player.transform.position, this.transform.position) < p) {



			animatorController.Play ("Attack");
		}
		else	if (Vector3.Distance (player.transform.position, this.transform.position) < followDist) {

				GetComponent<AudioSource>().Play ();
			Vector3 direction = player.transform.position - this.transform.position;

			animatorController.Play ("Walking");
		}



		//if (Input.GetKeyDown (KeyCode.A)) {
			//animatorController.Play ("Attack");
	//	}

	}





	void OnTriggerEnter(Collider other)
	{  
		if (other.gameObject.tag == "bullet") {
			--zombieHealth;
			Debug.Log (zombieHealth);
		}
	}


}
