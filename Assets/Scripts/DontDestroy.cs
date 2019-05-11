using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
    public float _MaxAngularVelocity;
    public float massScale;
    public GameObject _trigger;
    Destroy _destr;
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        _destr = GetComponent<Destroy>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _trigger.transform)
        {
            Destroy(_destr);
            rb.mass *= massScale;
            rb.maxAngularVelocity = _MaxAngularVelocity;
        }
    }
}
