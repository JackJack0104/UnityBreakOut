using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfGround : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    // 接触判定があったとき、Masterオブジェクトを探し、そのGameMasterスクリプトの中のGameOverメソッドを呼ぶ
    {
        GameObject.Find("Master").GetComponent<GameMaster>().GameOver("ゲーム失敗、また挑戦しよう"); 
    }
}