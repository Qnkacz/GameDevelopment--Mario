using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss : MonoBehaviour
{
    public static boss bs;
    public GameObject cv;
    public GameObject victory;
    void Start()
    {
        bs = this;
    }

    public void GameOver()
    {
        Time.timeScale = Time.timeScale * Time.deltaTime*2;
        cv.SetActive(true);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Victory()
    {
        Time.timeScale = Time.timeScale * Time.deltaTime * 2;
        victory.SetActive(true);
    }

}
