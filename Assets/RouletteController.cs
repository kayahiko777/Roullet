using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotSpeed = 0; //速度



    void Start()
    {
        //フレームレートを60に
        Application.targetFrameRate = 60;
        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスが押されたら回転速度を設定
        if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
        }

        //回転速度分、ルーレットを回転させる
        transform.Rotate(0, 0, this.rotSpeed);

        //ルーレットを減速させる
        this.rotSpeed *= 0.98f;
    }
}
