using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOnPod : MonoBehaviour {
    public float speed;
    public float speedSlowdown;
    public GameObject trigger;
    public GameObject _centerBody;
    public GameObject _targetToContinue;
    Rigidbody rb;
    public bool _hitTrigger = false;
    public bool _elevate = false;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		if(_hitTrigger)
        {
            rb.MovePosition(Vector3.MoveTowards(transform.position, _centerBody.transform.position, speed * Time.deltaTime));
            rb.angularVelocity = Vector3.Lerp(rb.angularVelocity, Vector3.zero, speedSlowdown * Time.deltaTime);
        }
	}


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == trigger.transform)
        {
            rb.velocity = Vector3.zero;
            _hitTrigger = true;
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (Vector3.Distance(rb.angularVelocity, Vector3.zero) < 0.1f && _hitTrigger)
        {
            //_centerBody.SetActive(false);
            _hitTrigger = false;
            _elevate = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform == _targetToContinue.transform)
        {
            Destroy(GetComponent<FixedJoint>());
        }
    }
}
