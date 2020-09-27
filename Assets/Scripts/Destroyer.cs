using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject masterObj; // Masterオブジェクトを入れる変数

    private void OnCollisionEnter(Collision col)
    {
        masterObj.GetComponent<GameMaster>().boxNum--; // Masterオブジェクト内のGameMasterスクリプトの中のboxNumを−1する
        Destroy(gameObject);
    }
}