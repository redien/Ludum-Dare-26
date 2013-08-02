using UnityEngine;
using System.Collections;

public class BackAndForthBehaviour : MonoBehaviour {
	
	public Transform StartPosition, EndPosition;
	public float Speed = 1.0f;
	float x;
	Vector3 startPosition, endPosition;
	
	// Use this for initialization
	void Start () {
		x = 0.0f;
		startPosition = StartPosition.position;
		endPosition = EndPosition.position;
	}
	
	// Update is called once per frame
	void Update () {
		x += Time.deltaTime;
		Vector3 position = transform.position;
		position = startPosition + (Mathf.Sin(x * Speed) + 1) * (endPosition - startPosition) * 0.5f;
		transform.position = position;
	}
}
