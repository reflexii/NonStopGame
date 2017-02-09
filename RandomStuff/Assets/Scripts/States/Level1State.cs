using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1State : GameState {

	void Awake () {
        Initialize();
    }

    public void Initialize()
    {
        stateName = "Level1";
    }

}
