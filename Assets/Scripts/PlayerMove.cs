using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public float speed;
    public float terminalAngVelocity;
    bool _input = true;
    Rigidbody rb = new Rigidbody();
    public GameObject trigger;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = terminalAngVelocity;
	}
	
	// Update is called once per frame
	void Update () {
        if (_input)
        {
            float X = Input.GetAxis("Horizontal");
            float Z = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(X * speed * Time.deltaTime, 0, Z * speed * Time.deltaTime);
            rb.AddForce(movement);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == trigger.transform)
            _input = false;
    }
}
