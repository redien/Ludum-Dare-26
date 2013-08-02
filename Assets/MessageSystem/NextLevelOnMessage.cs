using UnityEngine;
using System.Collections;

public class NextLevelOnMessage : MessageReceiver {
	public override void OnMessage(string message) {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
