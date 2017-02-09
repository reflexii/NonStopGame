using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuButtonScript : MonoBehaviour {

    void Update()
    {

    }

    public void StartButton()
    {
        Debug.Log("Start Button pressed");
        GameGlobals.Instance.gameStateManager.ChangeState(GameState.tStateType.Game);
    }

    public void ExitButton()
    {
        Debug.Log("Exit Button pressed");
        Application.Quit();
    }
}
