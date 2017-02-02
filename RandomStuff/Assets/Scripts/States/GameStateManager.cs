using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    public GameObject currentState;
    public GameState.tStateType newState;

    public void ChangeState(GameState.tStateType iState, string sLevelName = "")
    {
        Destroy(currentState);
        currentState = new GameObject();
        DontDestroyOnLoad(currentState);
        if (sLevelName != "")
        {
            newState = iState;
            SceneManager.LoadScene(sLevelName);
        }
        else
        {
            SetState(iState);
        }
            
    }

    private void SetState(GameState.tStateType iState)
    {
        switch (iState)
        {
            case GameState.tStateType.SplashScreen:
                currentState.AddComponent<SplashScreenState>();
                currentState.name = "GS: Splash Screen";
                SceneManager.LoadScene(currentState.GetComponent<SplashScreenState>().stateName);
                break;
            case GameState.tStateType.MainMenu:
                currentState.AddComponent<MainMenuState>();
                currentState.name = "GS: Main Menu";
                SceneManager.LoadScene(currentState.GetComponent<MainMenuState>().stateName);
                break;
            case GameState.tStateType.Game:
                currentState.AddComponent<Level1State>();
                currentState.name = "GS: Level1";
                SceneManager.LoadScene(currentState.GetComponent<Level1State>().stateName);
                break;
        }
        newState = GameState.tStateType.Error;
    }
}
