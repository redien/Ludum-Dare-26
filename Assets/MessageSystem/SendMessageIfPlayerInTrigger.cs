using UnityEngine;
using System.Collections;

public class SendMessageIfPlayerInTrigger : MessageReceiver {
	public MessageReceiver receiver;
	bool messageReceived = false;
	string message;
	
	public override void OnMessage(string message) {
		messageReceived = true;
		this.message = message;
	}
	
	void OnTriggerEnter(Collider other) {
		messageReceived = false;
	}
	
	void OnTriggerStay(Collider other) {
		if (other.tag == "Player" && messageReceived) {
			Debug.Log("Message if player in trigger");
			receiver.OnMessage(message);
			messageReceived = false;
		}
	}
}
