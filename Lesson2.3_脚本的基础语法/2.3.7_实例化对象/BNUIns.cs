using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
2.3.7 ʵ������Ϸ����
    ����һ��Sphere���󣬴���һ����ΪBNUIns�Ľű�������������������
    ��Sphere��ҷ��������Ϲ��صĽű��ı���prefab��
*/
public class BNUIns : MonoBehaviour
{
    public Transform prefab;
    private void Awake()
    {
        int i = 0;
        while (i < 5)
        {
            Instantiate(prefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);//Instantiateʵ��������
            i++;
        }
    }
}
