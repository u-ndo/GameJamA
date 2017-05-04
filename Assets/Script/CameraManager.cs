using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    public GameObject pants;

	// Use this for initialization
	void Start () {
        pants = GameObject.FindWithTag("Pants");
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(pants.transform.position.x+30, 0, -10);
	}
}
