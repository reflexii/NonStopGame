using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenState : GameState {

    float changeTime = 1f;
    float currentTime;
    bool doOnce = false;

	void Awake () {
        currentTime = 0;
        Initialize();
    }

    void Update () {
        currentTime += Time.deltaTime;

        if (currentTime >= changeTime && !doOnce)
        {
            Debug.Log("Changing scene to Main Menu");
            doOnce = true;
            GameGlobals.Instance.gameStateManager.ChangeState(tStateType.MainMenu);
        }
	}

    public void Initialize()
    {
        stateName = "SplashScreen";
    }
}
