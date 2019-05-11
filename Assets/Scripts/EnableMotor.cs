using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableMotor : MonoBehaviour {
    public GameObject _collidingObject;
    private void OnCollisionEnter(Collision collision)
    {
            gameObject.GetComponent<HingeJoint>().useMotor = true;
    }
}
