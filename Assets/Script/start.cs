using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	public void Selectstart()
    {
        SceneManager.LoadScene("select");
    }
    void FixedUpdate()
    {
        if (Input.GetButton("Jump"))
        {
            Selectstart();
        }
        if (Input.GetButton("Cancel"))
        {
            Application.Quit();
        }
    }
}
