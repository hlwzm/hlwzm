using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.3   ������Ϸ�������
    �½�һ��Cube,���ű�BNUComponent������Cube��
    ͨ��GetComponent��ȡ���ض����Transform���
*/
public class BNUComponent : MonoBehaviour
{
    void Update()
    {
        GetComponent<Transform>().Translate(1, 0, 0);//ͨ��GetComponent��ȡ���ض����Transform���
    }
}