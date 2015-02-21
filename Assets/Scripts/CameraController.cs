using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public static bool isMoving;
	public static GameObject player;
	public GameObject playerPosition;
	private Vector3 offset;
	private Vector3 initVector;

	// Use this for initialization
	void Start () {
		offset = (transform.position - playerPosition.transform.position);
		player = null;
		isMoving = false;
		initVector = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (player == null) return;
		if (isMoving == false) return;
		transform.position = player.transform.position + offset;
	}

	// Set it back to first position
	public void setInitCamera() {
		transform.position = initVector;
	}
}	