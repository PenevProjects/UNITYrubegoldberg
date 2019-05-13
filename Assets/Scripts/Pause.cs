using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    public Button _reset;
    public Button _exit;
    public GameObject _music;
    AudioSource _musicTrack;
    public bool paused = false;
    bool musicBool = true;

    private void Start()
    {
        _musicTrack = _music.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            paused = togglePause();
        if (paused)
        {
            _reset.gameObject.SetActive(true);
            _exit.gameObject.SetActive(true);
            if (musicBool)
            {
                _musicTrack.Pause();
                musicBool = false;
            }
        }
        else
        {
            _reset.gameObject.SetActive(false);
            _exit.gameObject.SetActive(false);
            if (!musicBool)
            {
                _musicTrack.UnPause();
                musicBool = true;
            }
        }
    }

    bool togglePause()
    {
        if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            return false;
        }
        else if (Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            return true;
        }
        else
            return true;
    }
}