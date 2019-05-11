using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindMove : MonoBehaviour {
    public GameObject _propellor;
    public GameObject _target;
    Rigidbody rb;
    HingeJoint hj;
    public float _explosionForce;
    public float _expolosionRadius;
	// Use this for initialization
	void Start () {
        hj = _propellor.GetComponent<HingeJoint>();
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 10;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (hj.useMotor)
        {
            rb.AddExplosionForce(_explosionForce, _propellor.transform.position, _expolosionRadius);
        }
	}
}
