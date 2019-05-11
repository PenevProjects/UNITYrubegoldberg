using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attachToRope : MonoBehaviour {
    public GameObject _attachObject;
    public GameObject _detachTrigger;
    public GameObject _attachTrigger;
    bool attached = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _detachTrigger.transform && attached)
        {
            Destroy(GetComponent<FixedJoint>());
            attached = false;
        }
        if (other.transform == _attachTrigger.transform && !attached)
        {
            gameObject.AddComponent<FixedJoint>();
            gameObject.GetComponent<FixedJoint>().connectedBody = _attachObject.GetComponent<Rigidbody>();
            attached = true;
        }
    }
}
