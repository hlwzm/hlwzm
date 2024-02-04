using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
3.2.3   Image
创建一个Image控件，取名为ImageBack，再创建一个Image，将其作为ImageBack的子控件
并为两个控件添加两张颜色深浅不一样的图片，新建一个脚本ImageTest,将其挂载在子控件Image上，
并将Image拖曳到脚本ImageTest中的变量上
*/
public class ImageTest : MonoBehaviour
{
    public Image image;
    float restTime = 12f;//技能剩余时间
    float coodDownTime = 12f;//技能冷却时间
    void Start()
    {
        image = this.GetComponent<Image>();
    }
    void Update()
    {
        if (restTime > 0)
        {
            restTime -= Time.deltaTime;
            image.fillAmount = restTime / coodDownTime;
        }
        if (restTime < 0)
        {
            restTime = 12;
        }
    }
}
