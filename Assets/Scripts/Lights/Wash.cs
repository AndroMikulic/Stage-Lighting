using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wash : MonoBehaviour {

	public bool debugging = false;
	public Color32 color = Color.white;
	public Animator anim;
	void Update(){
		if (debugging && Input.GetKeyDown (KeyCode.W)) {
			if (GetComponent<MyLight> ().isOn) {
				GetComponent<MyLight> ().TurnOff ();
			} else {
				GetComponent<MyLight> ().TurnOn (color);
			}
		}
		if (debugging && Input.GetKeyDown (KeyCode.Alpha1)) {
			anim.SetTrigger ("UpDown");
		}
	}
}
