using UnityEngine;
using System.Collections;

public class TileBehaviour : MonoBehaviour {
	
	float ScaleOrigin;
	bool invertedYOffset;
	
	[HideInInspector]
	public Vector3 originalPosition;
	Vector3 originalScale;

	// Use this for initialization
	protected virtual void Start () {
		originalPosition = this.transform.position;
		originalScale = transform.localScale;
		
		SectionBehaviour section = transform.parent.GetComponent<SectionBehaviour>();
		ScaleOrigin = section.GetScaleOrigin();
		invertedYOffset = section.InvertedYOffset;
	}

	// Update is called once per frame
	protected virtual void Update () {
		float lightFactor = LightSourceBehaviour.GetAccumulatedLightFactor(gameObject, LightSourceBehaviour.DefaultAttenuationFunction);

		Vector3 position;
		position = this.transform.position;
		position.y = ScaleOrigin + (originalPosition.y + getHeightOffset() - ScaleOrigin) * (invertedYOffset ? (1.0f - lightFactor) : lightFactor);
		this.transform.position = position;
		
		Vector3 scale;
		scale = originalScale;
		float scaleOffset = 0.1f * lightFactor;
		scale.x -= scaleOffset;
		scale.z -= scaleOffset;
		transform.localScale = scale;
	}
	
	protected virtual float getHeightOffset() {
		return 0.0f;
	}
}
