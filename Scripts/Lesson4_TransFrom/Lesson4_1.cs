using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Vector3.forward);
        //�൱������������ϵ��һ����������ϵ��һ�����Լ�Ϊԭ�������ϵ�������ԭ��λ�ÿ��ܲ�ͬ
        print("��������ת��������"+this.transform.InverseTransformDirection(new Vector3(1,0,1)));
        //���ص�ת��������
        print(this.transform .TransformPoint(new Vector3 (1,0,1)));//������Ӱ��
        print(this.transform.TransformDirection(new Vector3(1, 0, 1)));//��������Ӱ��
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
