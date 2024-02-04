using UnityEngine.UI;
using UnityEngine;
using SkillIndo;

public class RoleControSkill : MonoBehaviour
{
    public GameObject[] characterSkills; // 保存角色技能的数组预制体
    public ToggleGroup characterToggleGroup; // 角色选择的ToggleGroup
    public Transform parentTransform; // 父级对象的 Transform

    private Toggle[] characterToggles; // 存放所有角色的数组
    private GameObject UIPrefab; // UI预制体
    private Toggle lastToggle; // 上一次选择的Toggle

    // 定义枚举类型，用于指示角色类型
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
        // 获取所有Toggle组件
        characterToggles = characterToggleGroup.GetComponentsInChildren<Toggle>();
        // 初始化characterSkills数组
        characterSkills = new GameObject[characterToggles.Length];
        // 初始化UIPrefab为空
        UIPrefab = null;
        // 遍历characterSkills数组，为每个角色加载对应的技能预制体

        for (int i = 0; i < characterSkills.Length; i++)
        {
            string characterName = characterToggles[i].GetComponentInChildren<Toggle>().name;
            GameObject skillPrefab = Resources.Load<GameObject>("Skills/" + characterName + "Skills");
            if (skillPrefab == null)
            {
                Debug.LogError("未能找到角色" + characterName + "的技能预制体！");
            }
            characterSkills[i] = skillPrefab;
        }
        // 为每个Toggle组件的Toggle事件添加监听器
        foreach (Toggle toggle in characterToggles)
        {
            toggle.onValueChanged.AddListener(delegate
            {
                ToggleStateChanged(toggle);
            });
        }
        characterToggles[0].isOn = true; // 默认初始显示为第一个角色的技能
        ToggleStateChanged(characterToggles[0]);
    }
    // Toggle状态改变时调用的方法
    private void ToggleStateChanged(Toggle changedToggle)
    {
        if (changedToggle.isOn)
        {
            // 判断是否点击了同一个Toggle
            if (lastToggle != null && lastToggle == changedToggle)
            {
                return;
            }
            // 销毁上一次选择的预设体
            Destroy(UIPrefab);

            // 根据角色类型实例化对应的技能预制体
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
                    Debug.Log("无对应实例化对象");
                    break;
            }
            // 更新上一次选择的Toggle
            lastToggle = changedToggle;
        }
    }


    // 实例化技能预制体的方法
    public void InstanceSkill(E_Role e_Role)
    {
        if (characterSkills[(int)e_Role] != null)
        {
            // 实例化技能预制体
            UIPrefab = Instantiate(characterSkills[(int)e_Role]);
            // 将技能预制体设置为父级对象的子对象
            UIPrefab.transform.SetParent(parentTransform, false);
    
        }
        else
        {
            Debug.LogError("角色技能预制体为空！");
        }
    }
}