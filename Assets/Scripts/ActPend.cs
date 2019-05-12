using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActPend : MonoBehaviour {
    public GameObject _triggerObject;
    PendulumHelper _trigger;
    Rigidbody rb;
    bool _swinging = false;
    // Use this for initialization
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        _trigger = _triggerObject.GetComponent<PendulumHelper>();
    }
    private void FixedUpdate()
    {
        if (_trigger._triggered == true && !_swinging)
        {
            rb.isKinematic = false;
            _swinging = true;
        }
    }
}
