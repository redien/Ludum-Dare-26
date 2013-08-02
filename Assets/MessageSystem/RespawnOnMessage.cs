using UnityEngine;
using System.Collections;

public class RespawnOnMessage : MessageReceiver {
	
	public GameObject RespawnPoint;

	public override void OnMessage(string message) {
		// LOL
		Application.LoadLevel(Application.loadedLevel);
		/*
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		player.transform.position = RespawnPoint.transform.position;
		player.transform.rotation = RespawnPoint.transform.rotation;
		
		foreach (InventoryItem item in GameObject.FindObjectsOfType(typeof(InventoryItem))) {
			item.Respawn();
		}
		Debug.Log(player.GetComponent<CharacterController>().velocity);
		*/
	}
}
