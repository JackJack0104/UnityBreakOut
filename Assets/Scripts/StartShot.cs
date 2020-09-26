using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartShot : MonoBehaviour
{
    void Start () {
        // このスクリプトがアタッチされているオブジェクトのTransformの回転角情報をx=0, y=Random, z=0にする
        transform.eulerAngles = new Vector3(0, Random.Range(30, 120), 0);
        // このスクリプトがアタッチされているオブジェクトにアタッチされている"RigidBody"コンポーネントのAddForce関数を呼び、前方向に500の力を加える
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
    }
}