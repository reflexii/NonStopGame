using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1State : GameState {

	void Awake () {
        base.Start();
        stateName = "Level1";
    }
}
