using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    方法二：选中要添加事件的按钮，在Inspector窗口，找到Button组件下面的OnClick(),点击“+”添加，
    将Button控件拖曳到OnClick()下面的Object位置，在NoFunction找到挂载脚本中要执行的方法名
*/
public class ButtonTest : MonoBehaviour
{
    public void ClickButton()
    {
        print("通过拖曳形式添加监听事件");
    }
}
