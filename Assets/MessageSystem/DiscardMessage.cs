using UnityEngine;
using System.Collections;

public class DiscardMessage : MessageReceiver {
	
	public string Message;
	public MessageReceiver Receiver;
	
	public override void OnMessage(string message) {
		Receiver.OnMessage(Message);
	}
}
