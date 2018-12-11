using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusicCtrl : MonoBehaviour {
    public AudioClip sfx;
    public AudioSource audioSource;
	// Use this for initialization
	void Start () {
        audioSource.PlayOneShot(sfx, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
