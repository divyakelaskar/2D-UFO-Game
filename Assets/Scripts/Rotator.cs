using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(90 * Vector3.forward * Time.deltaTime);
	}
}
