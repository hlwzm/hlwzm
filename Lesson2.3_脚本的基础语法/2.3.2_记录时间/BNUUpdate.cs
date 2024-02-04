using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.2.2 fixedDeltaTime
    新建一个Cube,添加刚体组件，将Use Grivity失活，
    将脚本BNUUpdate挂载到主相机Main Camera上
    将Cube拖曳到主相机MainCamera挂载的脚本(BNUUpdate)变量gameObj上
    GetComponent：已知该对象，使用GetComponent可以获取到该对象上的所以组件或脚本
*/
public class BNUUpdate : MonoBehaviour
{
    public GameObject gameObj;//需要获取的游戏对象
    private void FixedUpdate()
    {
        Vector3 te = gameObj.GetComponent<Rigidbody>().transform.position;//获取刚体的位置坐标
        te.y += 5 * Time.fixedDeltaTime;//使刚体每秒延y轴上升5个单位
        gameObj.GetComponent<Rigidbody>().transform.position = te;//刷新位置
    }
}