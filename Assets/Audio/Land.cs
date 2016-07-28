using UnityEngine;
using System.Collections;

public class Land : MonoBehaviour {
	
	CharacterController controller;
	bool wasGrounded = true;
	
	// Use this for initialization
	void Start () {
		controller = transform.parent.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!wasGrounded && controller.isGrounded) {
			GetComponent<AudioSource>().Play();
		}
		
		wasGrounded = controller.isGrounded;
	}
}
