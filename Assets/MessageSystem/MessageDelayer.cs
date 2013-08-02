using UnityEngine;
using System.Collections;

public class MessageDelayer : MessageReceiver {
	public float DelayTime = 1.0f;
	public MessageReceiver Receiver;
	
	float timer = -1.0f;
	string message;
	
	// Update is called once per frame
	void Update () {
		if (timer >= 0.0f) {
			timer += Time.deltaTime;
		}
		
		if (timer >= DelayTime) {
			Debug.Log("Timer sent");
			Receiver.OnMessage(message);
			timer = -1.0f;
		}
	}
	
	public override void OnMessage(string message) {
		this.message = message;
		timer = 0.0f;
	}
}
