using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    public void DoSomething()
    {
        this.transform.Rotate(1, 0, 0);//让挂载自身脚本的对象Cube2绕x轴旋转
    }
}