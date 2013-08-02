using UnityEngine;
using System.Collections;

public class Steps : MonoBehaviour {
	
	CharacterController controller;
	
	// Use this for initialization
	void Start () {
		controller = transform.parent.GetComponent<CharacterController>();
		audio.Play();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (controller.isGrounded && controller.velocity.magnitude > 0.0f) {
			audio.volume = 0.05f;
		} else {
			audio.volume = 0.0f;
		}
	}
}
