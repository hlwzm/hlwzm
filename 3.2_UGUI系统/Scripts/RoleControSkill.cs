using UnityEngine.UI;
using UnityEngine;
using SkillIndo;

public class RoleControSkill : MonoBehaviour
{
    public GameObject[] characterSkills; // �����ɫ���ܵ�����Ԥ����
    public ToggleGroup characterToggleGroup; // ��ɫѡ���ToggleGroup
    public Transform parentTransform; // ��������� Transform

    private Toggle[] characterToggles; // ������н�ɫ������
    private GameObject UIPrefab; // UIԤ����
    private Toggle lastToggle; // ��һ��ѡ���Toggle

    // ����ö�����ͣ�����ָʾ��ɫ����
    public enum E_Role
    {
        AssassinRole,
        ElementalistRole,
        HolyDarknessRole,
        SymbioseRole,
        WarriorRole
    }
    private void Start()
    {
        // ��ȡ����Toggle���
        characterToggles = characterToggleGroup.GetComponentsInChildren<Toggle>();
        // ��ʼ��characterSkills����
        characterSkills = new GameObject[characterToggles.Length];
        // ��ʼ��UIPrefabΪ��
        UIPrefab = null;
        // ����characterSkills���飬Ϊÿ����ɫ���ض�Ӧ�ļ���Ԥ����

        for (int i = 0; i < characterSkills.Length; i++)
        {
            string characterName = characterToggles[i].GetComponentInChildren<Toggle>().name;
            GameObject skillPrefab = Resources.Load<GameObject>("Skills/" + characterName + "Skills");
            if (skillPrefab == null)
            {
                Debug.LogError("δ���ҵ���ɫ" + characterName + "�ļ���Ԥ���壡");
            }
            characterSkills[i] = skillPrefab;
        }
        // Ϊÿ��Toggle�����Toggle�¼���Ӽ�����
        foreach (Toggle toggle in characterToggles)
        {
            toggle.onValueChanged.AddListener(delegate
            {
                ToggleStateChanged(toggle);
            });
        }
        characterToggles[0].isOn = true; // Ĭ�ϳ�ʼ��ʾΪ��һ����ɫ�ļ���
        ToggleStateChanged(characterToggles[0]);
    }
    // Toggle״̬�ı�ʱ���õķ���
    private void ToggleStateChanged(Toggle changedToggle)
    {
        if (changedToggle.isOn)
        {
            // �ж��Ƿ�����ͬһ��Toggle
            if (lastToggle != null && lastToggle == changedToggle)
            {
                return;
            }
            // ������һ��ѡ���Ԥ����
            Destroy(UIPrefab);

            // ���ݽ�ɫ����ʵ������Ӧ�ļ���Ԥ����
            switch (changedToggle.name)
            {
                case "AssassinRole":
                    InstanceSkill(E_Role.AssassinRole);
                    break;
                case "ElementalistRole":
                    InstanceSkill(E_Role.ElementalistRole);
                    break;
                case "HolyDarknessRole":
                    InstanceSkill(E_Role.HolyDarknessRole);
                    break;
                case "SymbioseRole":
                    InstanceSkill(E_Role.SymbioseRole);
                    break;
                case "WarriorRole":
                    InstanceSkill(E_Role.WarriorRole);
                    break;
                default:
                    Debug.Log("�޶�Ӧʵ��������");
                    break;
            }
            // ������һ��ѡ���Toggle
            lastToggle = changedToggle;
        }
    }


    // ʵ��������Ԥ����ķ���
    public void InstanceSkill(E_Role e_Role)
    {
        if (characterSkills[(int)e_Role] != null)
        {
            // ʵ��������Ԥ����
            UIPrefab = Instantiate(characterSkills[(int)e_Role]);
            // ������Ԥ��������Ϊ����������Ӷ���
            UIPrefab.transform.SetParent(parentTransform, false);
    
        }
        else
        {
            Debug.LogError("��ɫ����Ԥ����Ϊ�գ�");
        }
    }
}