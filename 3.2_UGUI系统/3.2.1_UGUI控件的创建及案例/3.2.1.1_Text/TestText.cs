using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/*
3.2.2   TMP_Text�ı�
    �°汾��unity�У�Text����ʱΪ TMP_Text���ͣ��ϰ汾��ΪText����
Font Asset          ����TMPʹ�õ�������Դ
Font Style          �ı���ʽ������塢б���
Vertex Color        ���������ַ��Ķ�����ɫ(ָ������ɫ�ı�ǩ����)
Color Gradient      �Ƿ����ö�����ɫ����
Override Color Tags ����������Ի�ʹ�����е��ַ���������ɫ��ǩ����ʹ��Ĭ����ɫ
Font Size           �ַ���С
Auto Size           �Զ������ַ���С����ֵ����min��max֮��
Character Spacing   ���Ƶ����ַ�֮��ļ��
Spacing Options     �ֱ�����ַ����кͶ�֮��ľ���
Alignment           �����ı��Ķ��뷽ʽ
Enable Word Wrap    ���û�����Զ�����

    ����һ��UI-Text-TextMeshPro�ؼ����½�һ���ű�TestText,���������Text������
    ��Text�ؼ�������ҷ���ű�TestText�еı�����
*/
public class TestText : MonoBehaviour
{
    public TMP_Text testText;   //����һ���ı�����
    void Start()
    {
        testText.text = "Test����";       //���ı���ֵ
        testText.color = Color.green;    //�޸�������ɫ
        print(testText.text);            //��ȡ�ı�
    }
}

