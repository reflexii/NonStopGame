using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text distanceText;
    public Text endGameText;
    public Text coinText;

	void Start () {
        endGameText.enabled = false;
	}
	void Update () {
        distanceText.text = "Distance: " + (GameGlobals.Instance.score * GameGlobals.Instance.coinsCollected);

        if (!GameGlobals.Instance.isPlayerAlive)
        {
            if ((GameGlobals.Instance.score*GameGlobals.Instance.coinsCollected) > GameGlobals.Instance.highscore)
            {
                GameGlobals.Instance.highscore = (GameGlobals.Instance.score*GameGlobals.Instance.coinsCollected);
            }

            endGameText.enabled = true;
            endGameText.text = "Game finished! You scored: " + (GameGlobals.Instance.score * GameGlobals.Instance.coinsCollected) + ". Your highscore is: " + GameGlobals.Instance.highscore;
        } else
        {
            endGameText.enabled = false;
        }

        coinText.text = " "+(GameGlobals.Instance.coinsCollected - 1);
	}
}
