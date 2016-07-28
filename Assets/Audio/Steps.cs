using UnityEngine;
using System.Collections;

public class Steps : MonoBehaviour {
	
	CharacterController controller;
	
	// Use this for initialization
	void Start () {
		controller = transform.parent.GetComponent<CharacterController>();
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (controller.isGrounded && controller.velocity.magnitude > 0.0f) {
			GetComponent<AudioSource>().volume = 0.05f;
		} else {
			GetComponent<AudioSource>().volume = 0.0f;
		}
	}
}
