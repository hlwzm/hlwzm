using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.4.2 ȷ����Ϸ����Ĳ㼶��ϵ
    ����Capsule, Sphere, Cube������Ϸ���󣬽�Cube��ΪSphere���Ӷ����ٽ�Sphere��ΪCapsule���Ӷ���
    �½��ű�BNUParchild,�����������Ϸ����Sphere��
*/
public class BNUParchild : MonoBehaviour
{
    void Update()
    {
        this.transform.Find("Cube").Rotate(1, 0, 0);      //ͨ��Find���Ҷ��������Ӷ���
        this.transform.parent.Rotate(1, 0, 0);            //ͨ����ϵ���Ҹ�����
    }
}
