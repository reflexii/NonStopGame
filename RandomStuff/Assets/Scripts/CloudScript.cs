using UnityEngine;
using System.Collections;

public class CloudScript : MonoBehaviour {


    public float rotateSpeed;
	void Start () {
	
	}
	
	void Update () {
        gameObject.transform.Rotate(new Vector3(0f, 0f, 1f) * rotateSpeed * Time.deltaTime);
	}
}
