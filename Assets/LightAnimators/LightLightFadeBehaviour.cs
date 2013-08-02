using UnityEngine;
using System.Collections;

public class LightLightFadeBehaviour : MonoBehaviour {
	
	float originalIntensity;
	
	// Use this for initialization
	void Start () {
		originalIntensity = light.intensity;
	}
	
	// Update is called once per frame
	void Update () {
		float lightFactor = LightSourceBehaviour.GetAccumulatedLightFactor(gameObject, LightSourceBehaviour.DefaultAttenuationFunction);
		light.intensity = originalIntensity * lightFactor;
	}
}
