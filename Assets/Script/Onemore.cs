using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onemore : MonoBehaviour {

    public void SelectOnemore()
    {
        SceneManager.LoadScene("main");
    }
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            SelectOnemore();
        }
        if (Input.GetButton("Cancel"))
        {
            Application.Quit();
        }
    }
}

