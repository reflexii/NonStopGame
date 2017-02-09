using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuState : GameState {


    // Use this for initialization
    void Awake() {
        Initialize();
    }

    public void Initialize()
    {
        stateName = "MainMenu";
    }
}
