using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour {


    public Rigidbody2D rb;
    public float speed = 300.0f;

    public Transform tr;

    float h; //좌, 우 움직임
    float v; //위, 아래 움직임


	// Use this for initialization
	
    void Awake()
    {
        GameManager.HPInit = 5;
    }

	// Update is called once per frame
	void Update () {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        rb.velocity = dir * speed * Time.deltaTime;

        float size = Camera.main.orthographicSize;
        float offset = 0.4f;
        if (tr.position.y >= size - offset)
        {
            tr.position = new Vector3(tr.position.x, size - offset, 0);

        }
        if (tr.position.y <= -size + offset)
        {
            tr.position = new Vector3(tr.position.x, -size + offset, 0);

        }
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float wSize = Camera.main.orthographicSize * screenRatio;

        if (tr.position.x >= wSize - offset)
        {
            tr.position = new Vector3(wSize - offset, tr.position.y, 0);
        }
        if (tr.position.x <= -wSize + offset)
        {
            tr.position = new Vector3(-wSize + offset, tr.position.y, 0);
        }


    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("ENEMY"))
        {
            GameManager.HPInit--;
            if (GameManager.HPInit <= 0)
            {

                int lscroe = GameManager.score;
                write_score(lscroe);
                SceneManager.LoadScene("End");
            }
        }
    }
    void write_score(int score)
    {
        using (StreamWriter outputFile = new StreamWriter(@"./Score.txt", true))
        {
            outputFile.WriteLine(score);
        }
    }
}
