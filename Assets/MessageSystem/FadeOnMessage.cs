using UnityEngine;
using System.Collections;

public class FadeOnMessage : MessageReceiver {
	
	public GUITexture Target;
	public float Duration = 1.0f;
	float x;
	bool playing = false;
	bool fadingIn = false;
	
	// Use this for initialization
	void Start () {
		x = 0.0f;
	}
	
	public override void OnMessage(string message) {
		fadingIn = (message == "FadeIn");
		x = 0.0f;
		playing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (playing) {
			x += Time.deltaTime / Duration;
			if (x >= 1.0f) {
				playing = false;
			}
		}
		Color color = Target.color;
		color.a = fadingIn ? 1.0f - x : x;
		Target.color = color;
	}
}
