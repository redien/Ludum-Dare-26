using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SectionBehaviour : MonoBehaviour {
	
	public bool InvertedYOffset = false;
	
	TileBehaviour[] tiles;
	float scaleOrigin;

	// Use this for initialization
	void Awake () {
		tiles = transform.GetComponentsInChildren<TileBehaviour>();
		float lowestHeight = 10000.0f;
		foreach (TileBehaviour tile in tiles) {
			// Add tiles to section and set their original height to the lowest in the section.
			if (tile.transform.position.y < lowestHeight) {
				lowestHeight = tile.transform.position.y;
			}
		}
		
		scaleOrigin = lowestHeight;
	}

	public float GetScaleOrigin() {
		return scaleOrigin;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
