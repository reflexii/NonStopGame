using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGlobals : MonoBehaviour {

    private static GameGlobals _instance;

    public GameStateManager gameStateManager;
    public bool isPlayerAlive = true;
    public int coinsCollected = 1;
    public float score = 0;
    public float highscore = 0;
    public static GameGlobals Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameGlobals>();
            }
            return _instance;
        }
    }

	void Awake()
    {
        if (_instance == null)
        {
            DontDestroyOnLoad(gameObject);
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this);
        }
    }
}
