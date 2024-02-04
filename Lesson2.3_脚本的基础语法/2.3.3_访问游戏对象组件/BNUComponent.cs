using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.3   访问游戏对象组件
    新建一个Cube,将脚本BNUComponent挂载在Cube上
    通过GetComponent获取挂载对象的Transform组件
*/
public class BNUComponent : MonoBehaviour
{
    void Update()
    {
        GetComponent<Transform>().Translate(1, 0, 0);//通过GetComponent获取挂载对象的Transform组件
    }
}