using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.6   ˽�б����͹��б���
    ��������Cube���ֱ�ΪCube1.��Cube2
    ����һ����ΪBNUPubvar�Ľű������������Cube1��
    ��Cube��ҷ��Cube���صĽű��Ĺ��б���pubTrans��
    ����ʱͨ���ı�Cube2��λ�ò鿴��ӡ����
*/
public class BNUPubvar : MonoBehaviour
{
    public Transform pubTrans;  //���ڴ洢Cube2λ��
    private Transform priTrans;//���ڴ洢Cube1λ��
    void Start()
    {
        priTrans = this.transform;    //��Cubeλ����Ϣ��ֵ��priTrans
    }
    void Update()
    {
        if (Vector3.Distance(pubTrans.position, priTrans.position) < 10)//����������С��10���ʹ�ӡCube2λ����Ϣ
        {
            Debug.Log(pubTrans.position);
        }
        else
        {
            Debug.Log(Vector3.Distance(pubTrans.position, priTrans.position));////��������������10���ʹ�ӡ���������Ϣ
        }
    }
}
