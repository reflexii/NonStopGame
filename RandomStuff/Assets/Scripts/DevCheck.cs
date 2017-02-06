using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevCheck : MonoBehaviour {

    public string sceneName;

	// Use this for initialization
	void Awake () {
        GameObject g = GameObject.Find("GameGlobals");

        if (g == null) {
            DontDestroyOnLoad(gameObject);
            SceneManager.LoadScene("SplashScreen");
        }
	}
}
