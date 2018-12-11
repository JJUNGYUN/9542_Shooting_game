using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour {

	// Use this for initialization
    void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(600, 1024, true);
    }
    public void OnStartClick()
    {
        SceneManager.LoadScene("Play");
    }
    public void OnRankClick()
    {
        SceneManager.LoadScene("Rank");
    }
    public void OnExitClick()
    {
        Application.Quit();
    }

}
