using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
public class VRWalk : MonoBehaviour
{

	public Transform vrHead;
	public float toggleAngle = 30.0f;
	public float speed = 3.0f;
	public bool moveForward;
	public bool moveForward2;
	private GvrViewer gvrViewer;
	private CharacterController cc;
	private AudioClip m_JumpSound;
	private AudioSource m_AudioSource;
	// Use this for initialization
	void Start()
	{
		cc = GetComponent<CharacterController>();
		m_AudioSource = GetComponent<AudioSource>();
		gvrViewer = transform.GetChild (0).GetComponent<GvrViewer> ();

		vrHead = Camera.main.transform;
	}

	// Update is called once per frame
	void Update ()


	/*if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0f)
		{
			moveForward = true;
		}
		else
		{
			moveForward = false;
		}

		if (moveForward )
		{
			Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

			cc.SimpleMove(forward * speed);
		}
	}
}*/
	{
		if (Input.GetButtonDown ("Fire 1")) {
			moveForward2 = !moveForward2;
		}

		if (moveForward2) {

			Vector3 forward = vrHead.TransformDirection (Vector3.forward);
			//GetComponent<AudioSource>().Play ("Footstep01");
			cc.SimpleMove (forward * 10);

		}

		if (Input.GetButtonDown ("Fire1")) {
			moveForward = !moveForward;
		}

		if (moveForward) {

			Vector3 forward = vrHead.TransformDirection (Vector3.forward);
			//GetComponent<AudioSource>().Play ("Footstep01");
			cc.SimpleMove (forward * speed);

		}



	}


}









