using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotSpeed = 0; //���x



    void Start()
    {
        //�t���[�����[�g��60��
        Application.targetFrameRate = 60;
        
    }

    // Update is called once per frame
    void Update()
    {
        //�}�E�X�������ꂽ���]���x��ݒ�
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
        }

        //��]���x���A���[���b�g����]������
        transform.Rotate(0, 0, this.rotSpeed);

        //���[���b�g������������
        this.rotSpeed *= 0.98f;
    }
}
