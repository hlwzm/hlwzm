using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupCheck : MonoBehaviour
{
    public GameObject uiPrefab; // UI Ԥ�������
    public Transform parentTransform; // ��������� Transform
    private GameObject instantiatedUI; // ʵ������� UI ����
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener(ToggleCheckInstance);
    }
    public void ToggleCheckInstance(bool isOn)
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
