using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.4.3 通过名称或标签获取游戏对象
    创建Capsule,Sphere,Cube三个游戏对象，
    改名为   Cube2.3.4.3
            Capsule2.3.4.3
            Sphere2.3.4.3

    为Capsule添加名为"Cap"的标签
    创建脚本BNUFind,将其挂载在Sphere上
*/
public class BNUFind : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject obj1 = GameObject.Find("Cube2.3.4.3");//通过Find查找游戏对象
        obj1.transform.Rotate(1, 0, 0);
        GameObject obj2 = GameObject.FindWithTag("Cap");//通过FindWithTag标签查找游戏对象，效率更高
        obj2.transform.Rotate(1, 0, 0);
    }
}
