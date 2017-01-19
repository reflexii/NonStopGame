﻿using UnityEngine;
using System.Collections;

public class FloorPart : BaseScript {

    new void Start () {
        base.Start();
    }
	
	void Update () {
        Move();
        DestroyObject();
	}
    public override void DestroyObject()
    {
        if (gameObject.transform.position.z <= endingPosition.position.z)
        {
            fm.SpawnNewBlock();

            Destroy(gameObject);
        }
    }
}
