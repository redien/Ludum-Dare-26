using UnityEngine;
using System.Collections;

public class CollisionScaleBehaviour : MonoBehaviour {
	
	public float ScaleFactor = 100.0f;
	
	Vector3 originalScale;
	// Use this for initialization
	void Start () {
		originalScale = (GetComponent<Collider>() as BoxCollider).size;
	}
	
	// Update is called once per frame
	void Update () {
		float lightFactor = LightSourceBehaviour.GetAccumulatedLightFactor(gameObject, LightSourceBehaviour.DefaultAttenuationFunction);
		
		Vector3 scale = originalScale;
		scale.y *= ScaleFactor * lightFactor;
		(GetComponent<Collider>() as BoxCollider).size = scale;
	}
}
