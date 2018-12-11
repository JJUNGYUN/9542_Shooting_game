using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FireCtrl : MonoBehaviour {

    public GameObject[] pos;
    public GameObject bullet;
    public GameObject bullet2;
    public float delayTime = 0.2f;
    int random = 2;
    int check = 0;
    public AudioClip sfx;
    public AudioSource audioSource;
    
	// Use this for initialization
	void Start () {
        InvokeRepeating("Fire", 1.0f, delayTime);

	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(GameManager.score);
	}

    void Fire()
    {
        
        
        if (gameObject.CompareTag("PLAYER"))
        {
            audioSource.PlayOneShot(sfx, 0.2f);
        }
        for (int i = 0; i < pos.Length; i++)
        {
            if (gameObject.CompareTag("ENEMY"))
            {

                if (check == random)
                {
                    Instantiate(bullet2, pos[i].transform.position, pos[i].transform.rotation);
                    check = 0;
                }
                else
                {
                    Instantiate(bullet, pos[i].transform.position, pos[i].transform.rotation);
                    check++;
                    Debug.Log(check);
                }
            }
            if (gameObject.CompareTag("PLAYER"))
            {
                Instantiate(bullet, pos[i].transform.position, pos[i].transform.rotation);
            }
        }
    }
}
