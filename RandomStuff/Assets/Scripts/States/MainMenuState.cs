using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : GameState {

    float changeTime = 1f;
    float currentTime;

    // Use this for initialization
    new void Start () {
        base.Start();
        currentTime = 0;
        initialize();
    }

    public void initialize() {
        stateName = "MainMenu";
    }
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;

        if (currentTime >= changeTime)
        {
            Debug.Log("Changing scene to level1");
            GameGlobals.Instance.gameStateManager.ChangeState(tStateType.Game);
        }
    }
}
