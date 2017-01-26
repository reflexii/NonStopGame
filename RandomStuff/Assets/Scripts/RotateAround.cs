using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public Transform m_gcTransform;
	public float m_fDegrees;

	// Use this for initialization
	void Start () {
		m_gcTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

		m_gcTransform.Rotate(Vector3.up, m_fDegrees);
	}
}
