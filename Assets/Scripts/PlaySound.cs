using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
    public GameObject _collider;
    public AudioSource _clip;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform == _collider.transform)
            _clip.Play();
    }
}
