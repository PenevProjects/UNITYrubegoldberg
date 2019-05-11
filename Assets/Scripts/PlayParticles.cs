using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour {
    public GameObject _particles;
	// Use this for initialization
	void Start () {
        _particles.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        _particles.SetActive(true);

    }
}
