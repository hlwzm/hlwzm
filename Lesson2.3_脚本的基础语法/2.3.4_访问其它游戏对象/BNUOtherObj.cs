using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.4   ����������Ϸ��������
2.3.4.1 ͨ�����Բ鿴��ָ������
    1) ��������Cube��һ������ΪCube1,һ������ΪCube2
    2������һ���ű�������ΪBNUOtherObj�����������Cube1��
    3������һ���ű�������ΪTest�����������Cube2��
    4����Cube2��ҷ��Cube1���صĽű�(BNUOtherObj)����otherObj��
ͨ����ȡָ����Ϸ����Ľű����ԣ�ִ�л�ȡ���Ľű��еķ���
*/
public class BNUOtherObj : MonoBehaviour
{
    public GameObject otherObj;//��Ҫ��ȡ����Ϸ����ͨ��unity����ҷ����õ���Ҳ����Cube2
    void Update()
    {
        Test test = otherObj.GetComponent<Test>();//��ȡָ����Ϸ�����Ϲ��صĽű�
        test.DoSomething();//ִ�л�ȡ���Ľű��еķ���
    }
}
