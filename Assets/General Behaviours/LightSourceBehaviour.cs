using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightSourceBehaviour : MonoBehaviour {

	public static List<LightSourceBehaviour> lightSources = new List<LightSourceBehaviour>();
	public float Range = 15;
	
	public delegate float AttenuationDelegate (float distance, float lightRange);
	
	public static float DefaultAttenuationFunction(float distance, float lightRange) {
		return Mathf.Cos((distance * Mathf.PI) / (lightRange * 2));
	}
	
	public static float GetAccumulatedLightFactor(GameObject obj, AttenuationDelegate attenuationFunction) {
		float lightFactor = 0.0f;
		foreach (LightSourceBehaviour lightSource in LightSourceBehaviour.lightSources) {
			float distance = distanceOnXZPlane(obj.transform.position, lightSource.transform.position);
			lightFactor += lightFactorBasedOnDistanceAndLightRange(distance, lightSource.Range, attenuationFunction);
		}
		return Mathf.Min(lightFactor, 1.0f);
	}
	
	static float lightFactorBasedOnDistanceAndLightRange(float distance, float lightRange, AttenuationDelegate attenuationFunction) {
		if (distance > lightRange) {
			return 0.0f;
		} else {
			return attenuationFunction(distance, lightRange);
		}
	}
		
	static float distanceOnXZPlane(Vector3 a, Vector3 b) {
		a.y = 0;
		b.y = 0;
		return Mathf.Abs((a - b).magnitude);
	}
	
	// Use this for initialization
	void Start () {
		lightSources.Add(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
