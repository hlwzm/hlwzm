using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.7 实例化游戏对象
    创建一个Sphere对象，创建一个名为BNUIns的脚本，将其挂载在主相机上
    将Sphere拖曳到主相机上挂载的脚本的变量prefab上
*/
public class BNUIns : MonoBehaviour
{
    public Transform prefab;
    private void Awake()
    {
        int i = 0;
        while (i < 5)
        {
            Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);//Instantiate实例化对象
            i++;
        }
    }
}
