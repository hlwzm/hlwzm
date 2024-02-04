using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.1 位移与旋转
    unity中新建一个Cube,然后将脚本BNUTransR挂载在Cube上
    this 表示挂载自身脚本的对象
    transform.Rotate是旋转
    transform.Translate是位移 
*/
public class BNUTransR : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(2, 0, 0);//绕x轴旋转，每帧2°
        this.transform.Translate(0, 0, 1);//延z轴每帧移动一个单位
    }
}