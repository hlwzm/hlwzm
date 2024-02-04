using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.5   向量
    创建一个Cube,创建一个脚本BNUVec，将其挂载在Cube上
*/
public class BNUVec : MonoBehaviour
{
    public Vector3 position = new Vector3();//实例化Vector3
    void Start()
    {
        position = Vector3.right;    //为position赋值
    }
    void Update()
    {
        this.transform.Translate(position);//朝向量方向平移
    }
}
