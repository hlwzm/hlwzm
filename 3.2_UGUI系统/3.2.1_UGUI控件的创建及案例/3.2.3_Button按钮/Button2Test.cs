using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
3.2.4   Button ��ť
    ����һ����ť�ؼ�������һ���ű�Button2Test,���ű������ڰ�ť�ؼ���
    ��Ӱ�ť�����¼�
    ����һ��ͨ��������Ӽ����¼�
    this.gameObject.GetComponent<Button>().onClick.AddListener(Button2TestClick);
    ����Ӷ���¼����Ϳɴ���������¼�
*/
public class Button2Test : MonoBehaviour
{
    private string str = "�������Hello world";
    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(Button2TestClick);
        this.gameObject.GetComponent<Button>().onClick.AddListener(() => Button2TestClick2(str));
    }
    public void Button2TestClick()
    {
        Debug.Log("ͨ���ڴ�������Ӽ����¼�");
    }
    public void Button2TestClick2(string str)
    {
        Debug.Log(str);
    }
}
