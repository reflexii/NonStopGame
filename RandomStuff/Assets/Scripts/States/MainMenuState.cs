using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : GameState {

    float changeTime = 1f;
    float currentTime;

    // Use this for initialization
    new void Start () {
        base.Start();
        stateName = "MainMenuState";
        currentTime = 0;
    }
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;

        if (currentTime >= changeTime)
        {
            Debug.Log("Changing scene");
            GameGlobals.Instance.gameStateManager.ChangeState(GameState.tStateType.Game, "Level1");
        }
    }
}
