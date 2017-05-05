using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour {

    public AudioSource BGM;
    public AudioClip Loop;

	// Use this for initialization
	void Start () {
        BGM = GetComponent<AudioSource>();
        BGM.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (BGM.isPlaying == false)
        {
            BGM.clip = Loop;
            BGM.loop = true;
            BGM.Play();
        }
	}
}
