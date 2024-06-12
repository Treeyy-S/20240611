using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //スコア
    public int score = 10;
    //何かとぶつかった時に呼ばれる
    private void OnCollisionEnter(Collision collision)
    {
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScriptのインスタンスがありません。");
        }

        //ゲームオブジェクトを削除する
        Destroy(gameObject);
    }
}
