using UnityEngine;
using UnityEngine.UI;

public class ToggleGroupExample : MonoBehaviour
{
    public ToggleGroup toggleGroup;

    private void Start()
    {
        // ��ȡToggleGroup�µ�����Toggle
        Toggle[] toggles = toggleGroup.GetComponentsInChildren<Toggle>();

        // ����Toggle����
        foreach (Toggle toggle in toggles)
        {
            // ���Toggle״̬�ı�ļ����¼�
            toggle.onValueChanged.AddListener(delegate {
                ToggleStateChanged(toggle);
            });
            Debug.Log(toggle.name);
        }
    }

    // ��Toggle״̬�ı�ʱ�����ķ���
    private void ToggleStateChanged(Toggle changedToggle)
    {
        if (changedToggle.isOn)
        {
            Debug.Log(changedToggle.name + " ����ִ��");
            // ִ����Ӧ�Ĳ���
        }
    }
}