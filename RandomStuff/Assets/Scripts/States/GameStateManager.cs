using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour {

    public GameState.tStateType currentState;

    private SplashScreenState sss;
    private MainMenuState mms;
    private Level1State l1s;

    public void Start() {
        sss = GetComponent<SplashScreenState>();
        mms = GetComponent<MainMenuState>();
        l1s = GetComponent<Level1State>();

        activateAndChangeState(GameState.tStateType.SplashScreen, false);
    }

    public void activateAndChangeState(GameState.tStateType state, bool changeState = true) {
        if (state == GameState.tStateType.SplashScreen) {
            sss.initialize();
            sss.enabled = true;
            mms.enabled = false;
            l1s.enabled = false;
            if (changeState) {
                SceneManager.LoadScene(sss.stateName);
            }
            
        } else if (state == GameState.tStateType.MainMenu) {
            mms.initialize();
            sss.enabled = false;
            mms.enabled = true;
            l1s.enabled = false;
            if (changeState) {
                SceneManager.LoadScene(mms.stateName);
            }
        } else if (state == GameState.tStateType.Game) {
            l1s.initialize();
            sss.enabled = false;
            mms.enabled = false;
            l1s.enabled = true;
            if (changeState) {
                SceneManager.LoadScene(l1s.stateName);
            }
        }

        currentState = state;
    }

    public void ChangeState(GameState.tStateType iState = GameState.tStateType.Error)
    {
            activateAndChangeState(iState);       
    }
}
