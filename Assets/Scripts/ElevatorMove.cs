using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMove : MonoBehaviour {
    Rigidbody rb = new Rigidbody();
    public float elevatorSpeed;
    public GameObject _target;
    public GameObject _player;
    public GameObject _trigger;
    CenterOnPod flag;
    public bool _attached = false;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        flag = _player.GetComponent<CenterOnPod>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (flag._elevate)
        {
            _player.AddComponent<FixedJoint>();
            _player.GetComponent<FixedJoint>().connectedBody = rb;
            flag._elevate = false;
            _attached = true;
        }
        if (_attached)
        {
            rb.MovePosition(Vector3.MoveTowards(transform.position, _target.transform.position, elevatorSpeed * Time.deltaTime));
            if (Vector3.Distance(transform.position, _target.transform.position) == 0.0f)
            {
                _attached = false;
                Destroy(_player.GetComponent<FixedJoint>());
            }
        }
	}

}
