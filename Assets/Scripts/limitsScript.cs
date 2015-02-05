using UnityEngine;
using System.Collections;

public class limitsScript : MonoBehaviour {

	public PlayerController controllerScript;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag.Equals ("player1") || other.gameObject.tag.Equals ("player2")) {
			controllerScript.TriggerEntered();
		}
	}
}
