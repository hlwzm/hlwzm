using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.4   访问其它游戏对象的组件
2.3.4.1 通过属性查看器指定参数
    1) 创建两个Cube，一个命名为Cube1,一个命名为Cube2
    2）创建一个脚本，命名为BNUOtherObj，将其挂载在Cube1上
    3）创建一个脚本，命名为Test，将其挂载在Cube2上
    4）将Cube2拖曳到Cube1挂载的脚本(BNUOtherObj)变量otherObj上
通过获取指定游戏对象的脚本属性，执行获取到的脚本中的方法
*/
public class BNUOtherObj : MonoBehaviour
{
    public GameObject otherObj;//需要获取的游戏对象，通过unity中拖曳对象得到，也就是Cube2
    void Update()
    {
        Test test = otherObj.GetComponent<Test>();//获取指定游戏对象上挂载的脚本
        test.DoSomething();//执行获取到的脚本中的方法
    }
}
