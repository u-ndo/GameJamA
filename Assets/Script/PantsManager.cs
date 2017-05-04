using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantsManager : MonoBehaviour {

    public Rigidbody2D pantsBody;
    public GameObject pantsSprite;
    float kakudo=0;

    public float MaxSpeed;
    public float FirstSpeed;
    public float Curving;
    public float Rotate;

    // Use this for initialization
    void Start () {
		pantsBody =GetComponent<Rigidbody2D>();
        pantsBody.AddForce(transform.up*20, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        kakudo += 1;
        pantsSprite.transform.Rotate(0, 0, 35);
        //スペースボタンが入力されたとき
        if (Input.GetButton("Jump"))
        {
            pantsBody.AddForce(transform.up*1.5f, ForceMode2D.Impulse);
            if (pantsBody.velocity.x <= 45)
            {
                pantsBody.AddForce(transform.right, ForceMode2D.Impulse);
            }
        }
        if(pantsBody.velocity.x<=45)
        {
            pantsBody.AddForce(transform.right, ForceMode2D.Impulse);
        }
	}

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.tag=="Yuka")
        {
            //げーむおーばーしょり
            SceneManager.LoadScene("GameOver");
        }
    }
}
