using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.8   Эͬ������ж�
    ����һ����ΪBNUCoroutine�Ľű�������������������
    ����Ч��������ʼʱѭ����ӡ��ʾ��Ϣ��2s���ж�Эͬ����ֹͣ��ӡ
*/
public class BNUCoroutine : MonoBehaviour
{
    IEnumerator Start()
    {
        StartCoroutine("DoSomething", 2.0f); //����Эͬ����
        yield return new WaitForSeconds(1); //�ȴ�1s
        StopCoroutine("DoSomething");   //�ж�Эͬ����
    }
    IEnumerator DoSomething(float somePaeameter)    //����DoSomething����
    {
        while (true)                //��ʼѭ��
        {
            print("DoSomething Loop");  //�����ʾ��Ϣ
            yield return null;
        }
    }
}

