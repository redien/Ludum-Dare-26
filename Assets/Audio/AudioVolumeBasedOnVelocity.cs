using UnityEngine;
using System.Collections;

public class AudioVolumeBasedOnVelocity : MonoBehaviour {
	
	Vector3 previousPosition = Vector3.zero;
	float maxVelocity = 0.002f;
	float startTime;
	float accumulator = 0.0f;
	int count = 0;
	
	// Use this for initialization
	void Start () {
		startTime = Time.time + Random.value * 5.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (startTime != -1.0f && Time.time > startTime + 1.0f) {
			audio.loop = true;
			audio.volume = 0.0f;
			audio.Play();
			startTime = -1.0f;
		}

		if (startTime == -1.0f) {
			float length = Mathf.Abs((transform.parent.position - previousPosition).magnitude);
			float velocity = length / Time.deltaTime;
			accumulator += velocity;
			count += 1;
		}
		
		if (count > 3) {
			audio.volume = accumulator / maxVelocity / 3;
			count = 0;
			accumulator = 0.0f;
		}
		
		previousPosition = transform.parent.position;
	}
}
