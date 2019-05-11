using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassIncrease : MonoBehaviour {
    public float massScale;
    public GameObject _massInc;
    Rigidbody rb;
    bool scaled = false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform == _massInc.transform && !scaled)
        {
            rb.mass *= massScale;
            scaled = true;
        }
    }
}
