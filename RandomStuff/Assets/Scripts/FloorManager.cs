using UnityEngine;
using System.Collections;

public class FloorManager : MonoBehaviour {

    public GameObject startPos;

    public GameObject[] prefabList;

    

    public float difference = 7;
    public float blockSpeed;
    public int startingBlocksAmount;
    private Vector3 initialSpawningPosition = Vector3.zero;
    public int easyZoneAmount;

    void Start () {
        InitialSetup();
        startPos.transform.position = Vector3.zero + new Vector3(0f, 0f, (-21f + (startingBlocksAmount * difference)));
	}
	
	void Update () {
	
	}

    public void InitialSetup()
    {
        for (int i = 0; i < startingBlocksAmount; i++)
        {
            GameObject g;
            if (i < easyZoneAmount)
            {
                g = (GameObject)Instantiate(prefabList[0], initialSpawningPosition, Quaternion.identity);
            } else
            {
                g = (GameObject)Instantiate(RandomizeFloorPart(), initialSpawningPosition, Quaternion.identity);
            }
            
            g.GetComponent<FloorPart>().movementSpeed = blockSpeed;
            initialSpawningPosition += new Vector3(0f, 0f, difference);
        }
    }
    
    public void SpawnNewBlock()
    {
        GameObject g = (GameObject)Instantiate(RandomizeFloorPart(), startPos.transform.position, Quaternion.identity);
        g.GetComponent<FloorPart>().movementSpeed = blockSpeed;
    }

    public GameObject RandomizeFloorPart()
    {
        int randomized = Random.Range(0, 5);
        return prefabList[randomized];
    }
}
