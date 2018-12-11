using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class Rank : MonoBehaviour {

    public Text first;
    public Text second;
    public Text third;
    public Text fourth;
    public Text fifth;
    public Text sixth;
    public void OnExitClick()
    {
        SceneManager.LoadScene("Main");
    }

    // Use this for initialization
    List<int> Load_score()
    {
        string line;
        List<int> score_list = new List<int>();
        using (StreamReader rdr = new StreamReader(@"./score.txt"))
        {
            while ((line = rdr.ReadLine()) != null)
            {
                int score = Int32.Parse(line);
                score_list.Add(score);
            }

        }
        score_list.Sort();
        score_list.Reverse();

        return score_list;
    }
    void Start()
    {
        List<int> score_lsit = Load_score();

        try
        {
            int one = score_lsit[0];
            first.text = "1st :" + one.ToString("00000");
        }
        catch
        {
            first.text = "1st :None";
        }
        try
        {
            int two = score_lsit[1];
            second.text = "2nd :" + two.ToString("00000");
        }
        catch
        {
            second.text = "2nd :None";
        }
        try
        {
            int three = score_lsit[2];
            third.text = "3rd :" + three.ToString("00000");
        }
        catch
        {
            third.text = "3rd :None";
        }
        try
        {
            int four = score_lsit[3];
            fourth.text = "4th :" + four.ToString("00000"); ;
        }
        catch
        {
            fourth.text = "4th :None";
        }
        try
        {
            int five = score_lsit[4];
            fifth.text = "5th :" + five.ToString("00000");
        }
        catch
        {
            fifth.text = "5th :None";
        }
        try
        {
            int six = score_lsit[5];
            sixth.text = "6th :" + six.ToString("00000");
        }
        catch
        {
            sixth.text = "6th :None";
        }


    }


    // Update is called once per frame
    void Update()
    {

    }
}
