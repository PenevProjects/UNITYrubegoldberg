using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    public GameObject _player;
    public Material _mat2;
    Renderer _rndrr;
    bool _collided = false;
    private void Start()
    {
        _rndrr = GetComponent<Renderer>();
    }
    private void FixedUpdate()
    {
        if (_collided)
            _rndrr.material.color = Color.Lerp(_rndrr.material.color, _mat2.color, Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform == _player.transform)
           _collided = true;
    }
}
