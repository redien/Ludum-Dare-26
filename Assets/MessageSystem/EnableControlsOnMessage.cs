using UnityEngine;
using System.Collections;

public class EnableControlsOnMessage : MessageReceiver {
	
	GlobalScript script;
	
	void Awake() {
		script = GameObject.Find("GlobalObject").GetComponent<GlobalScript>();
	}
	
	public override void OnMessage(string message) {
		script.SetInputEnable(message == "true");
	}
}
