using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
3.2.5   Toggle
    创建三个Toggle，创建一个空物体作为三个Toggle的父对象，为空物体改名为ToggleGroup,为空物体添加ToggleGroup组件
    给每个Toggle的Group拖曳空物体ToggleGroup
    isOn表示选中，代码中if语句表示只有被选中时才进行监听，如果不加，则表示Toggle状态改变都会执行监听
*/
public class ToggleTest : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener(Toggle1TestOnclick);
    }
    public void Toggle1TestOnclick(bool isOn)
    {
        if (isOn)
        {
            Debug.Log("选择了按钮一");
        }
    }
}
