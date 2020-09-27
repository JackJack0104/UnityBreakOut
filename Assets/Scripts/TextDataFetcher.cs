using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDataFetcher : MonoBehaviour
{
    public Text resultMessageText;
    
    void Start()
    {
        // このスクリプトが読み込まれたとき、DataSenderクラスのresultMessageの中身を指定したテキストボックスに入れる
        resultMessageText.text = DataSender.resultMessage;
    }
}