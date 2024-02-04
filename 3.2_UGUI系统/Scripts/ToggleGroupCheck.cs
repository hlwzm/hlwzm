using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupCheck : MonoBehaviour
{
    public GameObject uiPrefab; // UI 预制体对象
    public Transform parentTransform; // 父级对象的 Transform
    private GameObject instantiatedUI; // 实例化后的 UI 对象
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener(ToggleCheckInstance);
    }
    public void ToggleCheckInstance(bool isOn)
    {
        if (instantiatedUI == null)
        {
             instantiatedUI = Instantiate(uiPrefab, parentTransform); // 实例化 UI 预制体，并设置父级对象                                                                     //    instantiatedUI.SetActive(true);
        }
        else
        {
            instantiatedUI.SetActive(!instantiatedUI.activeSelf); // 切换激活状态
        }   
    }
}
