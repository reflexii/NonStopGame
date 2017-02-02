using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour {

    public string stateName;
    public enum tStateType
    {
        Error = 0,
        SplashScreen,
        MainMenu,
        Game
    }

	protected void Start () {
        stateName = "BaseClass";
	}
	
	void Update () {
		
	}
}
