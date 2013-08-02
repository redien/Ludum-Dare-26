using UnityEngine;
using System.Collections;

public class LightProbingBehaviour : MonoBehaviour {
	
	public float StartIntensity = 1.0f;
	public float EndIntensity = 3.0f;
	public float Speed = 3.0f;
	
	float x = 0.0f;
	Color StartColor, EndColor;
	
	// Use this for initialization
	void Start () {
		StartColor = transform.parent.renderer.material.color;
		EndColor = StartColor - new Color(0.0f, 0.2f, 0.2f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		x += Time.deltaTime;
		light.intensity = StartIntensity + (Mathf.Sin(x * Speed) + 1) * (EndIntensity - StartIntensity) * 0.5f;
		transform.parent.renderer.material.color = StartColor + (Mathf.Sin(x * Speed) + 1) * (EndColor - StartColor) * 0.5f;
	}
}
