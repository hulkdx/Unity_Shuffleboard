using UnityEngine;
using System.Collections;

public class Menu1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount > 0) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			if (!Physics.Raycast(ray, out hit)){ return;}

			if (Input.GetTouch (0).phase == TouchPhase.Began)
			{
				if(hit.collider.name == "txt_Start Game")
				{
					hit.collider.renderer.material.color=Color.red;
				}
				else if (hit.collider.name == "txt_Quit Game")
				{
					hit.collider.renderer.material.color=Color.red;
				}
				else 
				{ 
					return; 
				}
			}
			else if (Input.GetTouch (0).phase == TouchPhase.Ended)
			{
				if(hit.collider.name == "txt_Start Game")
				{
					hit.collider.renderer.material.color=Color.white;
					Application.LoadLevel (0);
				}
				else if (hit.collider.name == "txt_Quit Game")
				{
					hit.collider.renderer.material.color=Color.white;
					Application.Quit();
				}
				else 
				{ 
					return; 
				}
			}
		}
	}
}
