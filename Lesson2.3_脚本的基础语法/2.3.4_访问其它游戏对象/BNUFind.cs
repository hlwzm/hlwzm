using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.4.3 ͨ�����ƻ��ǩ��ȡ��Ϸ����
    ����Capsule,Sphere,Cube������Ϸ����
    ����Ϊ   Cube2.3.4.3
            Capsule2.3.4.3
            Sphere2.3.4.3

    ΪCapsule�����Ϊ"Cap"�ı�ǩ
    �����ű�BNUFind,���������Sphere��
*/
public class BNUFind : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        GameObject obj1 = GameObject.Find("Cube2.3.4.3");//ͨ��Find������Ϸ����
        obj1.transform.Rotate(1, 0, 0);
        GameObject obj2 = GameObject.FindWithTag("Cap");//ͨ��FindWithTag��ǩ������Ϸ����Ч�ʸ���
        obj2.transform.Rotate(1, 0, 0);
    }
}
