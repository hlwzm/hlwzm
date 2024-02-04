using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle3Test : MonoBehaviour
{
    private void Start()
    {
        this.gameObject.GetComponent<Toggle>().onValueChanged.AddListener(Toggle3TestOnclick);
    }
    public void Toggle3TestOnclick(bool isOn)
    {
        if (isOn)
        {
            Debug.Log("选择了按钮三");
        }       
    }
}
