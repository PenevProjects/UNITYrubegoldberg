using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {

    public GameObject _collider;
    public GameObject _music;
    AudioSource _musicTrack;
    public GameObject _lobby;
    AudioSource _lobbyTrack;
    private void Start()
    {
        _musicTrack = _music.GetComponent<AudioSource>();
        _lobbyTrack = _lobby.GetComponent <AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform == _collider.transform)
        {
            _lobbyTrack.Stop();
            _musicTrack.Play();
        }
    }
}
