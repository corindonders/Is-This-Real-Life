using UnityEngine;
using System.Collections;

public class CameraMovement: MonoBehaviour {
	void Update() {
		transform.Translate(Vector3.forward * 1/6);
	}
}