using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.6   私有变量和公有变量
    创建两个Cube，分别为Cube1.，Cube2
    创建一个名为BNUPubvar的脚本，将其挂载在Cube1上
    将Cube拖曳到Cube挂载的脚本的公有变量pubTrans上
    运行时通过改变Cube2的位置查看打印窗口
*/
public class BNUPubvar : MonoBehaviour
{
    public Transform pubTrans;  //用于存储Cube2位置
    private Transform priTrans;//用于存储Cube1位置
    void Start()
    {
        priTrans = this.transform;    //将Cube位置信息赋值给priTrans
    }
    void Update()
    {
        if (Vector3.Distance(pubTrans.position, priTrans.position) < 10)//两点距离如果小于10，就打印Cube2位置信息
        {
            Debug.Log(pubTrans.position);
        }
        else
        {
            Debug.Log(Vector3.Distance(pubTrans.position, priTrans.position));////两点距离如果大于10，就打印两点距离信息
        }
    }
}
