using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.2   ��¼ʱ��
2.3.2.1 deltaTime
    �½�һ��Cube,���ű�BNUFTime���ص�Cube��
    deltaTime��ʾ֡���
*/
public class BNUFTime : MonoBehaviour
{
    private void Update()
    {
        this.transform.Rotate(10 * Time.deltaTime, 0, 0);//deltaTime��ʾ֡���
    }
}