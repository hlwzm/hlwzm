using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPanel : MonoBehaviour
{
    public GameObject uiPrefab; // UI Ԥ�������
    public Transform parentTransform; // ��������� Transform
    private GameObject instantiatedUI; // ʵ������� UI ����

    void Start()
    {
        this.gameObject.GetComponent<Button >().onClick.AddListener(TestPanelButtonFun);   
    }

    void TestPanelButtonFun()
    {
        if (instantiatedUI == null)
        {
            instantiatedUI = Instantiate(uiPrefab, parentTransform); // ʵ���� UI Ԥ���壬�����ø�������                                                                     //    instantiatedUI.SetActive(true);
        }
        else
        {
            instantiatedUI.SetActive(!instantiatedUI.activeSelf); // �л�����״̬
        }
    }
}
