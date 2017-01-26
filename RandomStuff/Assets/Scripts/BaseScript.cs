using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour {

    public float movementSpeed;
    public Transform endingPosition;
    public FloorManager fm;

    protected void Start()
    {
        endingPosition = GameObject.Find("EndingPos").transform;
        fm = GameObject.Find("FloorManager").GetComponent<FloorManager>();
    }

    public void Move()
    {
        gameObject.transform.position += new Vector3(0f, 0f, -1f) * movementSpeed * Time.deltaTime;
    }

    public void Update()
    {
        Move();
    }

    public virtual void DestroyObject()
    {
        if (gameObject.transform.position.z <= endingPosition.position.z)
        {
            Destroy(gameObject);
        }
    }
}
