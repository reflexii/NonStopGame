using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : BaseScript {

    public float rotateSpeedZ;
    public bool destroyObject = true;

	new void Start () {
        base.Start();
        movementSpeed = fm.blockSpeed;
    }
	
	new void Update () {
        base.Update();
        rotateObject();
        movementSpeed = fm.blockSpeed;
        if (destroyObject)
        {
            DestroyObject();
        }
        
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.transform.tag == "Player")
        {
            //Add Coins
            GameGlobals.Instance.coinsCollected++;
            
            Destroy(gameObject);
        }
    }

    void rotateObject()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeedZ);
    }
}
