using UnityEngine;
using System.Collections;

public class FallDamage : MonoBehaviour {
	
	public MessageReceiver respawnReceiver;
	CharacterController controller;
	float timer = 0.0f;
	Vector3 lastPosition;
	bool deadWhenGrounded = false;
	
	void Awake() {
		controller = GetComponent<CharacterController>();
		lastPosition = transform.position;
	}
	
	void Update() {
		timer += Time.deltaTime;
		if (timer > 1.0f) {
			if ((transform.position - lastPosition).y < -10.0f) {
				deadWhenGrounded = true;
			}
			timer = 0.0f;
			lastPosition = transform.position;
		}

		if (controller.isGrounded && deadWhenGrounded) {
			respawnReceiver.OnMessage("");
		}
	}
}
