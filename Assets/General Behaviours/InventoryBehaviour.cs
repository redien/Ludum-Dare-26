using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryBehaviour : MonoBehaviour {
	
	public InventoryItem item = null;
	public Transform AttachPoint, DetachPoint;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			if (item) {
				item.transform.parent = null;
				item.transform.position = DetachPoint.position;
				item.transform.rotation = DetachPoint.rotation;
				item.WasJustDetached = true;
				item.inventory = null;
				item = null;
			}
		}
	}
}
