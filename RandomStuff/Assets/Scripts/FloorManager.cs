using UnityEngine;
using System.Collections;

public class FloorManager : MonoBehaviour {

    public GameObject startPos;

    public GameObject[] prefabList;

    

    public float difference = 7;
    public float blockSpeed;
    public float blockSpeedIncreaseAmount;
    public int startingBlocksAmount;
    private Vector3 initialSpawningPosition = Vector3.zero;
    public int easyZoneAmount;
    public GameObject enemyObject;
    public float maximumSpeed;

    void Start () {
        InitialSetup();
        startPos.transform.position = Vector3.zero + new Vector3(0f, 0f, (-21f + (startingBlocksAmount * difference)));
	}
	
	void Update () {
        increaseBlockSpeed();
        updateBlockSpeed();
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

        int randomized = Random.Range(0, 4);
        if (randomized == 0)
        {
            Debug.Log("Spawned a baddie");
            Instantiate(enemyObject, startPos.transform.position + new Vector3(Random.Range(-2f, 2f), 1.5f, 20f), Quaternion.identity);
        }
    }

    public GameObject RandomizeFloorPart()
    {
        int randomized = Random.Range(0, 5);
        return prefabList[randomized];
    }

    public void increaseBlockSpeed()
    {
        if (blockSpeed < maximumSpeed)
        {
            blockSpeed += blockSpeedIncreaseAmount * Time.deltaTime;
        }
        
    }

    public void updateBlockSpeed()
    {
        GameObject[] go = GameObject.FindGameObjectsWithTag("FloorParts");
        
        for (int i = 0; i < go.Length; i++)
        {
            go[i].GetComponent<FloorPart>().movementSpeed = blockSpeed;
        }
    }
}
