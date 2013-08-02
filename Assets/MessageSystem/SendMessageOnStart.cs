using UnityEngine;
using System.Collections;

public class SendMessageOnStart : MonoBehaviour {
	
	public MessageReceiver Receiver;
	public string Message;
	
	// Use this for initialization
	void Start () {
		Receiver.OnMessage(Message);
	}
}
