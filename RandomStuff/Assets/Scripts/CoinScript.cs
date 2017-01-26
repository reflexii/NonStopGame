using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : BaseScript {

    public float rotateSpeedZ;

	new void Start () {
        base.Start();
        movementSpeed = fm.blockSpeed;
    }
	
	void Update () {
        base.Update();
        rotateObject();
        movementSpeed = fm.blockSpeed;
        DestroyObject();
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.transform.tag == "Player")
        {
            Debug.Log("Player found");
            Destroy(gameObject);
        }
    }

    void rotateObject()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeedZ);
    }
}
