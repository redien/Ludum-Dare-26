using UnityEngine;
using System.Collections;

public class WaterTileBehaviour : TileBehaviour {
	
	public static float WaveHeight = 0.6f;

	// Use this for initialization
	protected override void Start () {
		Vector3 position = transform.position;
		position.y = transform.parent.GetComponent<SectionBehaviour>().GetScaleOrigin();
		transform.position = position;
		base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () {
		base.Update();
	}
	
	protected override float getHeightOffset() {
		return (Mathf.Sin(Time.time + transform.position.x / Mathf.PI) + Mathf.Sin(Time.time + 2 + transform.position.z / Mathf.PI * 2)) / 2 * WaveHeight;
	}
}
