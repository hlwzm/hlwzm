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

        if (Input.GetMouseButtonDown(0))//0��1��2���������������������
        {
            print("��갴������");
        }

        if (Input.GetMouseButton(1)) //��갴���������
        {
            print("����");
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            print("w����");
        }
        //����ֵ��ΧΪ��-1��1��
        print(Input.GetAxis("Horizontal"));//ADˮƽ
        print(Input.GetAxis("Vertical"));//WS��ֱ
        print(Input.GetAxis("Mouse X"));//�������ˮƽ
        print(Input.GetAxis("Mouse Y"));//�������ˮƽ

    }

}
