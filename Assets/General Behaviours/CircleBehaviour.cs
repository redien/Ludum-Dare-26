using UnityEngine;
using System.Collections;

public class CircleBehaviour : MonoBehaviour {
	
	public float Radius = 10.0f;
	public float Speed = 3.0f;
	Vector3 origin;
	float x;
	
	// Use this for initialization
	void Start () {
		origin = transform.position;
		x = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		x += Speed * Time.deltaTime;
		transform.position = origin + new Vector3(Mathf.Cos(x), 0, Mathf.Sin(x)) * Radius;
	}
}
