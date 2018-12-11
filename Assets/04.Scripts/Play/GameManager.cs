using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour {

    public static int score = 0;
    public static int HPInit = 5;
    public Text HP;
    public Text scoreText;
    private int savedScore = 0;
    

	// Use this for initialization
	void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE :" + score.ToString("000000");
        HP.text = "X" + HPInit.ToString("0");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("End");
        }
	}


}
