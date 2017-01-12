using UnityEngine;
using System.Collections;

public class FloorPart : MonoBehaviour {

    private Transform m_transform;
    public float movementSpeed;
    private FloorManager fm;

    private Transform endingPosition;

	void Start () {
        m_transform = gameObject.transform;
        fm = GameObject.Find("FloorManager").GetComponent<FloorManager>();
        endingPosition = GameObject.Find("EndingPos").transform;
	}
	
	void Update () {
        m_transform.position += new Vector3(0f, 0f, -1f) * movementSpeed * Time.deltaTime;

        if (m_transform.position.z <= endingPosition.position.z)
        {
            fm.SpawnNewBlock();
            Destroy(gameObject);
        }
	}
}
