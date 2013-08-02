using UnityEngine;
using System.Collections;

public class SendMessageOnTriggerEnter : MonoBehaviour {
	public MessageReceiver Receiver;
	public string Message;
	
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			Receiver.OnMessage(Message);
		}
	}
}
