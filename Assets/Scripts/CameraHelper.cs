using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour {
    public bool _entered = false;
    private void OnCollisionEnter(Collision collision)
    {
        _entered = true;
    }
}
