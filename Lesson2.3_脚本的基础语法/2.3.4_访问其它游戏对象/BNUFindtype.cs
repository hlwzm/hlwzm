using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.4.4 ͨ���������ȡ��Ϸ����
    ������Ϸ����Cylinder��Sphere��Cube  ����Ϊ��Cylinder2.3.4.4��Sphere2.3.4.4��Cube2.3.4.4
    �����ű�Test2�����ñ�д�����������Sphere����Cube��
    �����ű�BUNFindtype�����������Cylinder��
    FindObjectOfType��FindObjectsOfType������������ʾ���ҹ�����ĳ���������Ϸ����
*/
public class BNUFindtype : MonoBehaviour
{
    void Start()
    {
        Test2 test2 = FindObjectOfType<Test2>();//��ʾ���ҹ���Test2�������Ϸ����
        Debug.Log(test2.gameObject.name);
        Test2[] tests = FindObjectsOfType<Test2>();////��ʾ���ҹ�����Test2�����������Ϸ����
        foreach (Test2 te in tests)
        {
            Debug.Log(te.gameObject.name);
        }
    }
}