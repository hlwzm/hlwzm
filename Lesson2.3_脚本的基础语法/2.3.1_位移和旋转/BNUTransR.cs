using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.1 λ������ת
    unity���½�һ��Cube,Ȼ�󽫽ű�BNUTransR������Cube��
    this ��ʾ��������ű��Ķ���
    transform.Rotate����ת
    transform.Translate��λ�� 
*/
public class BNUTransR : MonoBehaviour
{
    void Update()
    {
        this.transform.Rotate(2, 0, 0);//��x����ת��ÿ֡2��
        this.transform.Translate(0, 0, 1);//��z��ÿ֡�ƶ�һ����λ
    }
}