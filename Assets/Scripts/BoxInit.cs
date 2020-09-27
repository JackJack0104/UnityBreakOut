using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInit : MonoBehaviour
{
    public GameObject boxObjPrefab;
    public GameObject boxesObj;

    // Awakeはスタートより早く呼ばれる関数
    void Awake ()
    {
        GameObject masterObj = GameObject.Find("Master"); // 現在実体化しているオブジェクトからMasterという名前のものを探して格納する変数
        // 横に8回分
        for (int x = 0; x < 8; x++)
        {
            // 縦に5回分
            for (int y = 0; y < 5; y++)
            {
                GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
                g.transform.position = new Vector3((2f + (1F * y)), 0.4f, (-4.2f + (1.2f * x)));
                g.GetComponent<Destroyer>().masterObj = masterObj;
            }
        }
    }
}