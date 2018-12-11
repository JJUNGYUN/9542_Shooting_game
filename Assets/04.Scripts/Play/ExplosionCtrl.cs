using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCtrl : MonoBehaviour {

    public AudioClip sfx;
    public AudioSource audioSource;


	// Use this for initialization
	void Start () {
        audioSource.PlayOneShot(sfx, 0.5f);
        Invoke("destroy", 0.75f);
	}
	
    void destroy()
    {
        Destroy(this.gameObject);
    }

}
