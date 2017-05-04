using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class select : MonoBehaviour {

    const string PANTS_KEY = "pants";

    public void SelectSelect1()
    {
        PlayerPrefs.SetInt(PANTS_KEY, 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene("main");
    }
    public void SelectSelect2()
    {
        PlayerPrefs.SetInt(PANTS_KEY, 2);
        PlayerPrefs.Save();
        SceneManager.LoadScene("main");
    }
    public void SelectSelect3()
    {
        PlayerPrefs.SetInt(PANTS_KEY, 3);
        PlayerPrefs.Save();
        SceneManager.LoadScene("main");
    }
    public void SelectSelect4()
    {
        PlayerPrefs.SetInt(PANTS_KEY, 4);
        PlayerPrefs.Save();
        SceneManager.LoadScene("main");
    }
    public void SelectSelect5()
    {
        PlayerPrefs.SetInt(PANTS_KEY, 5);
        PlayerPrefs.Save();
        SceneManager.LoadScene("main");
    }
}
