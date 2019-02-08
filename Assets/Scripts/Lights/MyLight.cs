using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLight : MonoBehaviour {

	public enum MyLightType {STROBE, WASH, BEAM};
	public MyLightType  type;
	public GameObject bulb;
	public GameObject lense;
	public Material lenseMat;
	public bool isOn = false;
    public Color dynamicColor;

	public void Start(){
		foreach (Material mat in lense.GetComponent<MeshRenderer>().materials) {
			if (mat.name.StartsWith("LENSE_COLOR")) {
				lenseMat = mat;
				break;
			}
		}
	}

    void Update()
    {
        if (isOn)
        {
            lenseMat.SetColor("_Color", dynamicColor);
            lenseMat.SetColor("_MKGlowColor", dynamicColor);
            lenseMat.SetFloat("_MKGlowPower", 1.0f);
            bulb.GetComponent<Light>().color = dynamicColor;
        }
    }

	public void TurnOn(Color32 methodColor){
		if (!isOn) {
            dynamicColor = (Color) methodColor;
            bulb.SetActive(true);
            isOn = true;
		}
	}

    public void TurnOff(){
		if (isOn) {
			isOn = false;
			bulb.SetActive (false);
			lenseMat.SetColor ("_Color", Color.black);
			lenseMat.SetFloat ("_MKGlowPower", 0.0f);
		}
	}


}
