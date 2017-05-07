using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectManager : MonoBehaviour {

    public GameObject PantsSprite;
    public Image image;

    public GameObject TextObject;
    public Text text;
    public GameObject StatusObject;
    public Text status;

    public Sprite pants1;
    public Sprite pants2;
    public Sprite pants3;
    public Sprite pants4;
    public Sprite pants5;

    const string PANTS_KEY = "pants";

    public void SelectSelect1()
    {
        image.sprite = pants1;
        text.text = "君の浮気相手はどうやら一般的なパンティーがお好みらしい。\n" +
            "しかし油断してはならない。シンプルでかわいらしい見た目は君の彼女にあらぬ疑いを持たせるには十分すぎる。";
        status.text = "速さ:★★ 重さ:★★ 操作性:★★★ ";
        PlayerPrefs.SetInt(PANTS_KEY, 1);
        PlayerPrefs.Save();
    }
    public void SelectSelect2()
    {
        image.sprite = pants2;
        text.text = "君の浮気相手は若々しいかわいい女の子のようだ。\n" +
            "いつか見たアニメのヒロインもこんな下着を着ていたが、君はアニメの主人公ではない。ハーレムENDは諦めたほうがよさそうだ。";
        status.text = "速さ:★★★ 重さ:★★ 操作性:★★ ";
        PlayerPrefs.SetInt(PANTS_KEY, 2);
        PlayerPrefs.Save();
    }
    public void SelectSelect3()
    {
        image.sprite = pants3;
        text.text = "君の浮気相手は大人の雰囲気を漂わせる女性である。\n" +
            "薄く軽い素材のパンティーは煽情的で、これを見た男性は皆興奮してしまう。君の彼女も興奮するだろう、ただし、違う意味で。";
        status.text = "速さ:★☆ 重さ:★ 操作性:★☆";
        PlayerPrefs.SetInt(PANTS_KEY, 3);
        PlayerPrefs.Save();
    }
    public void SelectSelect4()
    {
        image.sprite = pants4;
        text.text = "君の浮気相手はかわいらしいパンツがお好みらしい。\n" +
            "ヒラヒラしたフリルに視線がくぎ付けになってしまう。もちろんそれは君の彼女も例外ではない。";
        status.text = "速さ:★★ 重さ:★★ 操作性:★★★☆ ";
        PlayerPrefs.SetInt(PANTS_KEY, 4);
        PlayerPrefs.Save();
    }
    public void SelectSelect5()
    {
        image.sprite = pants5;
        text.text = "君の浮気相手は非常に豪快な女性のようだ\n" +
            "もしかしたら君の下着に見えるかもしれないが…残念ながら君の彼女はそうは思わないらしい。";
        status.text = "速さ:☆ 重さ:★★★★★ 操作性:☆ ";
        PlayerPrefs.SetInt(PANTS_KEY, 5);
        PlayerPrefs.Save();
    }

    public void SelectStart()
    {
        SceneManager.LoadScene("Main");
    }

    // Use this for initialization
    void Start () {
        PantsSprite = GameObject.Find("NowPants").gameObject as GameObject;
        image = PantsSprite.GetComponent<Image>();
        TextObject= GameObject.Find("PantsText").gameObject as GameObject;
        text = TextObject.GetComponent<Text>();
        StatusObject = GameObject.Find("Status").gameObject as GameObject;
        status = StatusObject.GetComponent<Text>();
        SelectSelect1();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump"))
        {
            SelectStart();
        }
        if (Input.GetButton("Cancel"))
        {
            Application.Quit();
        }
    }
}
