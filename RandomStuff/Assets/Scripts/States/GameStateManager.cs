using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    public GameState.tStateType currentState;

    private SplashScreenState sss;
    private MainMenuState mms;
    private Level1State l1s;

    void Awake() {
        sss = GetComponent<SplashScreenState>();
        mms = GetComponent<MainMenuState>();
        l1s = GetComponent<Level1State>();

        activateAndChangeState(GameState.tStateType.SplashScreen, false);

        GameObject g = GameObject.Find("DeveloperCheck");

        if (g != null) {
            Debug.Log("Found devcheck");
            SceneManager.LoadScene(g.GetComponent<DevCheck>().sceneName);
            Destroy(g);
        }

    }

    public void activateAndChangeState(GameState.tStateType state, bool changeState = true) {

        activateScripts(state);

        if (changeState) {

            switch(state) {
                case GameState.tStateType.SplashScreen:
                    SceneManager.LoadScene(sss.stateName);
                    break;
                case GameState.tStateType.MainMenu:
                    SceneManager.LoadScene(mms.stateName);
                    break;
                case GameState.tStateType.Game:
                    SceneManager.LoadScene(l1s.stateName);
                    break;
            }
        }

        currentState = state;
    }

    public void ChangeState(GameState.tStateType iState = GameState.tStateType.Error)
    {
            activateAndChangeState(iState);
    }

    public void activateScripts(GameState.tStateType type) {
        sss.enabled = false;
        mms.enabled = false;
        l1s.enabled = false;

        switch (type) {
            case GameState.tStateType.SplashScreen:
                sss.enabled = true;
                break;
            case GameState.tStateType.MainMenu:
                mms.enabled = true;
                break;
            case GameState.tStateType.Game:
                l1s.enabled = true;
                break;
        }
    }
}
