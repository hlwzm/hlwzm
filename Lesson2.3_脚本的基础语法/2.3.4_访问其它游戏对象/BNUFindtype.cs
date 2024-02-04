using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.4.4 通过组件名获取游戏对象
    创建游戏对象Cylinder，Sphere，Cube  改名为：Cylinder2.3.4.4，Sphere2.3.4.4，Cube2.3.4.4
    创建脚本Test2，不用编写，将其挂载在Sphere，与Cube上
    创建脚本BUNFindtype，将其挂载在Cylinder上
    FindObjectOfType，FindObjectsOfType这两个方法表示查找挂载了某个组件的游戏对象
*/
public class BNUFindtype : MonoBehaviour
{
    void Start()
    {
        Test2 test2 = FindObjectOfType<Test2>();//表示查找挂载Test2组件的游戏对象
        Debug.Log(test2.gameObject.name);
        Test2[] tests = FindObjectsOfType<Test2>();////表示查找挂载了Test2组件的所有游戏对象
        foreach (Test2 te in tests)
        {
            Debug.Log(te.gameObject.name);
        }
    }
}