using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
3.2.5   Toggle
    ��������Toggle������һ����������Ϊ����Toggle�ĸ�����Ϊ���������ΪToggleGroup,Ϊ���������ToggleGroup���
    ��ÿ��Toggle��Group��ҷ������ToggleGroup
    isOn��ʾѡ�У�������if����ʾֻ�б�ѡ��ʱ�Ž��м�����������ӣ����ʾToggle״̬�ı䶼��ִ�м���
*/
public class ToggleTest : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener(Toggle1TestOnclick);
    }
    public void Toggle1TestOnclick(bool isOn)
    {
        if (isOn)
        {
            Debug.Log("ѡ���˰�ťһ");
        }
    }
}
