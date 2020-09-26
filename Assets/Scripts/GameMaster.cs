using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadSceneを使うために必要

public class GameMaster : MonoBehaviour
{
    public int boxNum;
    public float nowTime;

    void Start () 
    {
        nowTime = 0;
    }

    void Update ()
    {
        nowTime += Time.deltaTime;
        if(boxNum <= 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Result");
    }
}