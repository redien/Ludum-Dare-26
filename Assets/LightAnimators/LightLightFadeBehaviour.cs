using UnityEngine;
using System.Collections;

public class LightLightFadeBehaviour : MonoBehaviour {
	
	float originalIntensity;
	
	// Use this for initialization
	void Start () {
		originalIntensity = GetComponent<Light>().intensity;
	}
	
	// Update is called once per frame
	void Update () {
		float lightFactor = LightSourceBehaviour.GetAccumulatedLightFactor(gameObject, LightSourceBehaviour.DefaultAttenuationFunction);
		GetComponent<Light>().intensity = originalIntensity * lightFactor;
	}
}
