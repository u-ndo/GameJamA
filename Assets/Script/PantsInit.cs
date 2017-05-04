using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsInit : MonoBehaviour {

    public GameObject[] pants = new GameObject[6];
    const string PANTS_KEY = "pants";

    // Use this for initialization
    void Awake () {
        Instantiate(pants[PlayerPrefs.GetInt(PANTS_KEY,1)]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
