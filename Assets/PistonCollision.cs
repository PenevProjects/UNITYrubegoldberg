using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonCollision : MonoBehaviour {
    public bool _collided = false;
    private void OnCollisionEnter(Collision collision)
    {
        _collided = true;
    }
}
