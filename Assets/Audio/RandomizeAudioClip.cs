using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomizeAudioClip : MonoBehaviour {
	
	public List<AudioClip> clips = new List<AudioClip>();
	
	// Use this for initialization
	void Awake () {
		int i = Random.Range(0, clips.Count);
		audio.clip = clips[i];
	}
}
