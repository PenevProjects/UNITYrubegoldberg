using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour {
    public GameObject _reference1;
    CenterOnPod _playerCenter;
    public GameObject _reference2;
    public GameObject _reference3;
    CameraHelper _camerahelp2;
    CameraHelper _camerahelp3;
    Animator _animator;
    // Use this for initialization
    void Start () {
        _playerCenter = _reference1.GetComponent<CenterOnPod>();
        _camerahelp2 = _reference2.GetComponent<CameraHelper>();
        _camerahelp3 = _reference3.GetComponent<CameraHelper>();
        _animator = GetComponent<Animator>();
        _animator.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (_playerCenter._hitTrigger == true)
        {
            _animator.enabled = true;
            _animator.Play("FirstSector");
        }
        if (_camerahelp2._entered == true)
        {
            _animator.Play("SecondSector");
        }
        if (_camerahelp3._entered == true)
        {
            _camerahelp2._entered = false;
            _animator.enabled = true;
            _animator.Play("ThirdSector");
            
        }
    }
}
