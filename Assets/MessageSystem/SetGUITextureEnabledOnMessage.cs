using UnityEngine;
using System.Collections;

public class SetGUITextureEnabledOnMessage : MessageReceiver {
	public GUITexture texture;
	
	public override void OnMessage(string message) {
		texture.enabled = (message == "true") ? true : false;
	}
}
