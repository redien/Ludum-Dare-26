using UnityEngine;
using System.Collections;

public class GlobalHelp : MonoBehaviour {
	
	[HideInInspector]
	public bool DiedFromFall = false;
	public MessageReceiver Receiver;
	
	void Awake() {
		DontDestroyOnLoad(this);
		DontDestroyOnLoad(Receiver.gameObject);
	}
	
	void OnLevelWasLoaded(int level) {
		if (DiedFromFall) {
			Receiver.OnMessage("true");
		}
	}
}
