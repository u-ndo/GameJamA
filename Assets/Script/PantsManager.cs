using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantsManager : MonoBehaviour {

    public Rigidbody2D pantsBody;
    public GameObject pantsSprite;

    //パンツごとの性格付け用の数値
    public float MaxSpeed;      //最高速
    public float FirstSpeed;    //初速(Y方向)
    public float Curving;       //浮上力
    public float Rotate;        //回転する速度

    // Use this for initialization
    void Start () {
		pantsBody =GetComponent<Rigidbody2D>();
        //初速付与
        pantsBody.AddForce(transform.up*FirstSpeed, ForceMode2D.Impulse);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //回転します
        pantsSprite.transform.Rotate(0, 0,Rotate);
        //スペースボタンが入力されたとき
        if (Input.GetButton("Jump"))
        {
            //浮上処理
            pantsBody.AddForce(transform.up*Curving, ForceMode2D.Impulse);
            if (pantsBody.velocity.x <= MaxSpeed)
            {
                pantsBody.AddForce(transform.right, ForceMode2D.Impulse);
            }
        }
        if(pantsBody.velocity.x<= MaxSpeed)
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
        if(trigger.tag=="Mado")//仮置き
        {
            //ゲームクリア処理
        }
    }
}
