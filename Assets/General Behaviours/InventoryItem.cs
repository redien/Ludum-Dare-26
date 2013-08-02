using UnityEngine;
using System.Collections;

public class InventoryItem : MonoBehaviour {
	public MessageReceiver OnPickupReceiver;
	public string OnPickupMessage;
	
	Vector3 originalPosition;
	Quaternion originalRotation;

	[HideInInspector]
	public InventoryBehaviour inventory = null;
	
	// Use this for initialization
	void Start () {
		originalPosition = transform.position;
		originalRotation = transform.rotation;
	}
	
	public void Respawn() {
		transform.parent = null;
		transform.position = originalPosition;
		transform.rotation = originalRotation;
		if (inventory) {
			if (inventory.item == this) {
				inventory.item = null;
			}
			inventory = null;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	[HideInInspector]
	public bool WasJustDetached = false;
	
	void OnTriggerExit(Collider other) {
		InventoryBehaviour otherInventory = other.gameObject.GetComponentInChildren<InventoryBehaviour>();
		
		if (otherInventory && otherInventory == inventory) {
			WasJustDetached = false;
		}
	}
	
	void OnTriggerEnter(Collider other) {
		inventory = other.gameObject.GetComponentInChildren<InventoryBehaviour>();
		
		if (inventory && inventory.item == null && !WasJustDetached) {
			transform.parent = inventory.transform;
			transform.position = inventory.AttachPoint.position;
			transform.rotation = inventory.AttachPoint.rotation;
			inventory.item = this;
			if (OnPickupReceiver != null) {
				OnPickupReceiver.OnMessage(OnPickupMessage);
			}
		}
	}
}
