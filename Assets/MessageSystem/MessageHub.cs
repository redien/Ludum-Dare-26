using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MessageHub : MessageReceiver {
	public List<MessageReceiver> receivers = new List<MessageReceiver>();

	public override void OnMessage(string message) {
		foreach (MessageReceiver receiver in receivers) {
			receiver.OnMessage(message);
		}
	}
}
