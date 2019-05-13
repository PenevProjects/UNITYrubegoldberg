using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piston : MonoBehaviour {
    public GameObject _base;
    PistonCollision _pc;
    Vector3 current;
	// Use this for initialization
	void Start () {
        current = transform.position;
        _pc = _base.GetComponent<PistonCollision>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (_pc._collided)
        {
            transform.position = Vector3.MoveTowards(transform.position, current - (new Vector3(0f, 0f, 0.6f)), 2*Time.deltaTime);
        }
	}
}
