using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour {

	public bool debugging = false;
	public Color32 color = Color.white;
	void Update(){
		if (debugging && Input.GetKeyDown (KeyCode.B)) {
			if (GetComponent<MyLight> ().isOn) {
				GetComponent<MyLight> ().TurnOff ();
			} else {
				GetComponent<MyLight> ().TurnOn (color);
			}
		}
	}
}
