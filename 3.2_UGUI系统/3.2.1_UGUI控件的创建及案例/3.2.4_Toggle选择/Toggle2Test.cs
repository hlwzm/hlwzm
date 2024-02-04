using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle2Test : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener(Toggle2TestOnclick);
    }
    public void Toggle2TestOnclick(bool isOn)
    {
        if (isOn)
        {
            Debug.Log("选择了按钮二");
        }  
    }
}
