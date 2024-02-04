using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.8   协同程序和中断
    创建一个名为BNUCoroutine的脚本，将其挂载在主相机上
    程序效果：程序开始时循环打印提示信息，2s后中断协同程序并停止打印
*/
public class BNUCoroutine : MonoBehaviour
{
    IEnumerator Start()
    {
        StartCoroutine("DoSomething", 2.0f); //开启协同程序
        yield return new WaitForSeconds(1); //等待1s
        StopCoroutine("DoSomething");   //中断协同程序
    }
    IEnumerator DoSomething(float somePaeameter)    //声明DoSomething方法
    {
        while (true)                //开始循环
        {
            print("DoSomething Loop");  //输出提示信息
            yield return null;
        }
    }
}

