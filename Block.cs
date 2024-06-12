using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //�X�R�A
    public int score = 10;
    //�����ƂԂ��������ɌĂ΂��
    private void OnCollisionEnter(Collision collision)
    {
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScript�̃C���X�^���X������܂���B");
        }

        //�Q�[���I�u�W�F�N�g���폜����
        Destroy(gameObject);
    }
}
