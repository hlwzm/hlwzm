using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.4.2 确定游戏对象的层级关系
    创建Capsule, Sphere, Cube三个游戏对象，将Cube作为Sphere的子对象，再将Sphere作为Capsule的子对象
    新建脚本BNUParchild,将其挂载在游戏对象Sphere上
*/
public class BNUParchild : MonoBehaviour
{
    void Update()
    {
        this.transform.Find("Cube").Rotate(1, 0, 0);      //通过Find查找对象名，子对象
        this.transform.parent.Rotate(1, 0, 0);            //通过关系查找父对象
    }
}
