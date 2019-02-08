using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBeam : MonoBehaviour {

	public bool debugging = false;
	public Color32 color = Color.white;
	public Animator anim;
	void Update(){
		if (debugging && Input.GetKeyDown (KeyCode.M)) {
			if (GetComponent<MyLight> ().isOn) {
				GetComponent<MyLight> ().TurnOff ();
			} else {
				GetComponent<MyLight> ().TurnOn (color);
			}
		}
		if (debugging && Input.GetKeyDown (KeyCode.Alpha2)) {
			anim.SetTrigger ("UpDown");
		}
	}
}
