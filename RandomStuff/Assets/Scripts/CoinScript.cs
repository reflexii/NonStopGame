using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.transform.tag == "Player")
        {
            Debug.Log("Player found");
            Destroy(gameObject);
        }
    }
}
