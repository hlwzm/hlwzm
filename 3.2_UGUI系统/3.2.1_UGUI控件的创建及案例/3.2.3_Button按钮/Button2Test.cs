using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
3.2.4   Button 按钮
    创建一个按钮控件，创建一个脚本Button2Test,将脚本挂载在按钮控件上
    添加按钮监听事件
    方法一：通过代码添加监听事件
    this.gameObject.GetComponent<Button>().onClick.AddListener(Button2TestClick);
    可添加多个事件，和可传入参数的事件
*/
public class Button2Test : MonoBehaviour
{
    private string str = "传入参数Hello world";
    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(Button2TestClick);
        this.gameObject.GetComponent<Button>().onClick.AddListener(() => Button2TestClick2(str));
    }
    public void Button2TestClick()
    {
        Debug.Log("通过在代码中添加监听事件");
    }
    public void Button2TestClick2(string str)
    {
        Debug.Log(str);
    }
}
