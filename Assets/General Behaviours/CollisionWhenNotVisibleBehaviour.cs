using UnityEngine;
using System.Collections;

public class CollisionWhenNotVisibleBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float lightFactor = LightSourceBehaviour.GetAccumulatedLightFactor(gameObject, LightSourceBehaviour.DefaultAttenuationFunction);
		if (lightFactor > 0.4f) {
			if (collider.enabled) {
				collider.enabled = false;
			}
		} else {
			if (!collider.enabled) {
				collider.enabled = true;
			}
		}
	}
}
