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
            GameOver(nowTime.ToString("F0") + "秒でクリアできた！");
        }
    }

    public void GameOver(string resultMesseage) // string型のresultMessageを受け取る
    {
        DataSender.resultMessage = resultMesseage; // 受け取った引数をstatic変数に格納する
        SceneManager.LoadScene("Result");
    }
}