using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  print(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))//0，1，2代表鼠标左右中三个按键
        {
            print("鼠标按键按下");
        }

        if (Input.GetMouseButton(1)) //鼠标按键长按检测
        {
            print("长按");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            print("w按下");
        }
        //返回值范围为（-1，1）
        print(Input.GetAxis("Horizontal"));//AD水平
        print(Input.GetAxis("Vertical"));//WS垂直
        print(Input.GetAxis("Mouse X"));//鼠标左右水平
        print(Input.GetAxis("Mouse Y"));//鼠标上下水平

    }

}
