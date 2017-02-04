using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1State : GameState {

	new void Start () {
        base.Start();
        initialize();
	}

    public void initialize() {
        stateName = "Level1";
    }
}
