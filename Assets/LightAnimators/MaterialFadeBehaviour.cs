using UnityEngine;
using System.Collections;

public class MaterialFadeBehaviour : MonoBehaviour {
	
	public Material StartMaterial;
	public Material EndMaterial;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float lightFactor = LightSourceBehaviour.GetAccumulatedLightFactor(gameObject, LightSourceBehaviour.DefaultAttenuationFunction);
		Color color = StartMaterial.color;
		color.r = StartMaterial.color.r + (EndMaterial.color.r - StartMaterial.color.r) * lightFactor;
		color.g = StartMaterial.color.g + (EndMaterial.color.g - StartMaterial.color.g) * lightFactor;
		color.b = StartMaterial.color.b + (EndMaterial.color.b - StartMaterial.color.b) * lightFactor;
		GetComponent<Renderer>().material.color = color;
	}
}
