using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOnAndOff : MonoBehaviour {
    public Button _reset;
    public Button _exit;
    public GameObject _mainCamera;
    Pause _pause;
    Animator _cameraAnim;
    // Use this for initialization
    void Start() {
        _cameraAnim = _mainCamera.GetComponent<Animator>();
        _reset.gameObject.SetActive(false);
        _exit.gameObject.SetActive(true);
        _pause = GetComponent<Pause>();
        _pause.paused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update() {
        if (_cameraAnim.GetCurrentAnimatorStateInfo(0).IsName("ThirdSector") && _cameraAnim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            _pause.enabled = false;
            gameObject.SetActive(true);
            _reset.gameObject.SetActive(true);
            _exit.gameObject.SetActive(true);
        }
    }
}
