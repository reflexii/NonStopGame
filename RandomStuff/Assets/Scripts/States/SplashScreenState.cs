using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenState : GameState {

    float changeTime = 1f;
    float currentTime;

	new void Start () {
        base.Start();
        stateName = "SplashScreenState";
        currentTime = 0;
	}
	
	void Update () {
        currentTime += Time.deltaTime;

        if (currentTime >= changeTime)
        {
            Debug.Log("Changing scene");
            GameGlobals.Instance.gameStateManager.ChangeState(GameState.tStateType.MainMenu, "MainMenu");
        }
	}
}
