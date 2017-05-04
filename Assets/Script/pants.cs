using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pants : MonoBehaviour {

    public Rigidbody2D pantsBody;

    // Use this for initialization
    void Start () {
		pantsBody =GetComponent<Rigidbody2D>();
        pantsBody.AddForce(transform.up*10, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        pantsBody.AddForce(transform.right, ForceMode2D.Impulse);
	}

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.tag=="Yuka")
        {
            //げーむおーばーしょり

        }
    }
}
