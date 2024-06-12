using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
   //GameObject
    public GameObject blockPrefab;      //�u���b�N�̃v���t�@�u
    //�u���b�N�̍��W�E�傫��
    float span = 0.3f;      //�u���b�N�̊Ԋu
    int row = 4;            //�u���b�N�̗�
    int col = 7;            //�u���b�N�̍s
    int blockScaleX = 2;    //�u���b�N�̕�
    int blockScaleY = 1;    //�u���b�N�̍���
    // Start is called before the first frame update
    void Start()
    {
        //�u���b�N�̍��W
        int px = -7, py = 5;         //�u���b�N��X���W��Y���W
        //�u���b�N�̕\��
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                //�Q�[���I�u�W�F�N�g�Ƃ��Đ���
                GameObject go = Instantiate(blockPrefab);
                go.transform.position = new Vector3(px + (j * (span + blockScaleX)), py + (i * (span + blockScaleY)), 0);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

