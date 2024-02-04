using SkillIndo;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
/*
 ��δ��������ڴ����������Ľű��������Ǵ����и����ֵ�ע��˵����
ChildToggle���洢���� Toggle �����顣
skillToggleGroup������ Toggle ��� ToggleGroup �����
otherObj�����ڻ�ȡ TestJsonSkill �������Ϸ����
skillDescriptionText��TestJsonSkill ��������ڸ��¼��������ı���
lastToggle����¼��һ��ѡ��� Toggle��
�� Start �����У����ǻ�ȡ�����е� Toggle����Ϊÿ�� Toggle ����˼��������� Toggle ״̬�����仯ʱ������� ToggleStateChanged �������д���
ToggleStateChanged ��������ѡ��� Toggle ���ƣ�ʹ�� UpdateSkillDescription ���������¼��������ı�����󣬽���һ��ѡ��� Toggle ����Ϊ��ǰѡ��� Toggle
 */
public class SkillDescription : MonoBehaviour
{
    Toggle[] ChildToggle;                           // ���� Toggle ������
    public ToggleGroup skillToggleGroup;             // ���� Toggle ��
    public GameObject otherObj;                      // ���ڻ�ȡ TestJsonSkill �������Ϸ����
    private RWJsonSkill skillDescriptionText;      // TestJsonSkill ��������ڸ��¼��������ı�
    private Toggle lastToggle;                       // ��һ��ѡ��� Toggle

    private void Start()
    {
        ChildToggle = skillToggleGroup.GetComponentsInChildren<Toggle>();   // ��ȡ���е� Toggle
        skillDescriptionText = otherObj.GetComponent<RWJsonSkill>();     // ��ȡ TestJsonSkill ���

        foreach (Toggle toggle in ChildToggle)
        {
            toggle.onValueChanged.AddListener(delegate
            {
                ToggleStateChanged(toggle);    // Ϊÿ�� Toggle ��Ӽ�����
            });
        }
    }
    // ���� Toggle ״̬�ı�ķ���
    void ToggleStateChanged(Toggle changedToggle)
    {
        GetChangerToggleName();
        if (changedToggle.isOn)
        {
            if (lastToggle != null && lastToggle == changedToggle)
            {
                return;   // �����һ��ѡ��� Toggle �͵�ǰѡ��� Toggle ��ͬ���򲻽��д���
            }
            skillDescriptionText.UpdateSkillDescription(changedToggle.name,  GetChangerToggleName());   // ���¼��������ı�
//            Debug.Log("changedToggle.name="+changedToggle.name);
            lastToggle = changedToggle;   // ������һ��ѡ��� Toggle
        }
    }
    public string GetChangerToggleName( )
    {
 //       Debug.Log("this.gameObject.name = "+this.gameObject.name);
        return this.gameObject.name;
    }
}