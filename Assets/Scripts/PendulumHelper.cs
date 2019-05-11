using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumHelper : MonoBehaviour {
    public GameObject _player;
    public bool _triggered = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _player.transform)
            _triggered = true;
    }
}
