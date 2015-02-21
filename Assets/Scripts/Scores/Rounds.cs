using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Rounds : MonoBehaviour {
	public static int round;
	Text text;

	void Awake () {
		round = 1;
		text = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = round.ToString();
	}
}
