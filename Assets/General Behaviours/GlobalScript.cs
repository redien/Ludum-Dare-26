using UnityEngine;
using System.Collections;

public class GlobalScript : MonoBehaviour {
		
	public static GlobalScript instance;
	public MouseLook[] mouseLookScripts;
	public FPSInputController inputController;

	// Use this for initialization
	void Awake () {
		instance = this;
		Screen.lockCursor = true;
		mouseLookScripts = GameObject.FindGameObjectWithTag("Player").GetComponentsInChildren<MouseLook>();
		inputController = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<FPSInputController>();

		LightSourceBehaviour.lightSources.Clear();
	}
	
	public void SetInputEnable(bool enabled) {
		inputController.enabled = enabled;
		foreach (MouseLook script in mouseLookScripts) {
			script.enabled = enabled;	
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			Screen.lockCursor = true;
			SetInputEnable(true);
		}
		
		if (!Screen.lockCursor) {
			SetInputEnable(false);
		}
		
		if (!Application.isEditor && Input.GetKey(KeyCode.Escape)) {
			Application.Quit();
		}
	}
}
