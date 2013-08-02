using UnityEngine;
using System.Collections;

public class StartPointBehaviour : MonoBehaviour {
	// Use this for initialization
	void Start () {
		GameObject player = GameObject.FindGameObjectWithTag("Player");
		player.transform.position = transform.position;
		player.transform.rotation = transform.rotation;
	}
}
