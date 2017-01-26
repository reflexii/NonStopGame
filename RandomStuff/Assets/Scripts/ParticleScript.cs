using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {

    private ParticleSystem ps;

	void Start () {
        ps = GetComponent<ParticleSystem>();
        ps.Play();
	}
	
	void Update () {
		if (!ps.IsAlive())
        {
            Destroy(gameObject);
        }
	}
}
