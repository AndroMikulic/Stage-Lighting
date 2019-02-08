using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Vector3 moveDirection = new Vector3(0,0,0);
	public float moveSpeed = 1.0f;
    public float rotateSpeed = 1.0f;

    public float yaw = 0.0f;
    public float pitch = 0.0f;

    void Update(){
		moveDirection = Input.GetAxisRaw ("Vertical") * Vector3.forward + Input.GetAxisRaw ("Horizontal")  * Vector3.right;
        moveDirection *= moveSpeed;
		if (Input.GetMouseButton (1)) {
            yaw += rotateSpeed * Input.GetAxis("Mouse X");
            yaw = yaw % 360;
            pitch = pitch % 180;
            pitch -= rotateSpeed * Input.GetAxis("Mouse Y");
            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
            transform.Translate (moveDirection * Time.deltaTime);
		}
	}
}
