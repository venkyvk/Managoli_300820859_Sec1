using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

    //private instance variables
    private AudioSource[] _audiosources; //array of audio sources
    private AudioSource _cloudAudioSource, _islandAudioSource;


	// Use this for initialization
	void Start () {
        this._audiosources = this.GetComponents<AudioSource>();
        this._cloudAudioSource = this._audiosources[1];
        this._islandAudioSource = this._audiosources[2];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D otherGameObject)
    {
        if(otherGameObject.tag == "Island")
        {
            this._islandAudioSource.Play(); //Play the Yay sound
        }
        if (otherGameObject.tag == "Cloud")
        {
            this._cloudAudioSource.Play(); //PLay the thunder sound
        }
    }
}
