using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.2   记录时间
2.3.2.1 deltaTime
    新建一个Cube,将脚本BNUFTime挂载到Cube上
    deltaTime表示帧间隔
*/
public class BNUFTime : MonoBehaviour
{
    private void Update()
    {
        this.transform.Rotate(10 * Time.deltaTime, 0, 0);//deltaTime表示帧间隔
    }
}