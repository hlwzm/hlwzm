using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupExample : MonoBehaviour
{
    public ToggleGroup toggleGroup;

    private void Start()
    {
        // 获取ToggleGroup下的所有Toggle
        Toggle[] toggles = toggleGroup.GetComponentsInChildren<Toggle>();

        // 遍历Toggle数组
        foreach (Toggle toggle in toggles)
        {
            // 添加Toggle状态改变的监听事件
            toggle.onValueChanged.AddListener(delegate {
                ToggleStateChanged(toggle);
            });
            Debug.Log(toggle.name);
        }
    }

    // 当Toggle状态改变时触发的方法
    private void ToggleStateChanged(Toggle changedToggle)
    {
        if (changedToggle.isOn)
        {
            Debug.Log(changedToggle.name + " 正在执行");
            // 执行相应的操作
        }
    }
}