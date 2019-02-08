using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strobe : MonoBehaviour {

	public bool debuging = false;
	public bool toggle = false;
	public float blinksPerSecond = 60.0f;
	public Color32 color = Color.white;

	void Update(){
		if (debuging && Input.GetKeyDown (KeyCode.S)) {
			if (toggle) {
				Off ();
			} else {
				On ();
			}
		}
	}

	void On(){
		toggle = true;
		StartCoroutine (MyUpdate ());
	}

	void Off(){
		toggle = false;
	}

	IEnumerator MyUpdate(){
		while (toggle) {
			GetComponent<MyLight> ().TurnOn (color);
			yield return new WaitForSeconds (1 / blinksPerSecond);
			GetComponent<MyLight> ().TurnOff ();
			yield return new WaitForSeconds (1 / blinksPerSecond);
		}
		GetComponent<MyLight> ().TurnOff ();
	}
}
