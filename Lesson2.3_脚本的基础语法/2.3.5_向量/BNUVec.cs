using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.5   ����
    ����һ��Cube,����һ���ű�BNUVec�����������Cube��
*/
public class BNUVec : MonoBehaviour
{
    public Vector3 position = new Vector3();//ʵ����Vector3
    void Start()
    {
        position = Vector3.right;    //Ϊposition��ֵ
    }
    void Update()
    {
        this.transform.Translate(position);//����������ƽ��
    }
}
