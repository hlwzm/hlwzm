using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/*
3.2.2   TMP_Text文本
    新版本的unity中，Text声明时为 TMP_Text类型，老版本的为Text类型
Font Asset          设置TMP使用的字体资源
Font Style          文本格式，如粗体、斜体等
Vertex Color        设置所有字符的顶点颜色(指定了颜色的标签除外)
Color Gradient      是否启用顶点颜色渐变
Override Color Tags 启用这个属性会使得所有的字符都忽视颜色标签，，使用默认颜色
Font Size           字符大小
Auto Size           自动调整字符大小，其值介于min和max之间
Character Spacing   控制单个字符之间的间距
Spacing Options     分别调整字符、行和段之间的距离
Alignment           控制文本的对齐方式
Enable Word Wrap    启用或禁用自动换行

    创建一个UI-Text-TextMeshPro控件，新建一个脚本TestText,将其挂载在Text对象上
    将Text控件对象拖曳到脚本TestText中的变量上
*/
public class TestText : MonoBehaviour
{
    public TMP_Text testText;   //创建一个文本变量
    void Start()
    {
        testText.text = "Test测试";       //给文本赋值
        testText.color = Color.green;    //修改字体颜色
        print(testText.text);            //读取文本
    }
}

