using SkillIndo;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
/*
 这段代码是用于处理技能描述的脚本。以下是代码中各部分的注释说明：
ChildToggle：存储技能 Toggle 的数组。
skillToggleGroup：技能 Toggle 组的 ToggleGroup 组件。
otherObj：用于获取 TestJsonSkill 组件的游戏对象。
skillDescriptionText：TestJsonSkill 组件，用于更新技能描述文本。
lastToggle：记录上一次选择的 Toggle。
在 Start 方法中，我们获取了所有的 Toggle，并为每个 Toggle 添加了监听器。当 Toggle 状态发生变化时，会调用 ToggleStateChanged 方法进行处理。
ToggleStateChanged 方法根据选择的 Toggle 名称，使用 UpdateSkillDescription 方法来更新技能描述文本。最后，将上一次选择的 Toggle 更新为当前选择的 Toggle
 */
public class SkillDescription : MonoBehaviour
{
    Toggle[] ChildToggle;                           // 技能 Toggle 的数组
    public ToggleGroup skillToggleGroup;             // 技能 Toggle 组
    public GameObject otherObj;                      // 用于获取 TestJsonSkill 组件的游戏对象
    private RWJsonSkill skillDescriptionText;      // TestJsonSkill 组件，用于更新技能描述文本
    private Toggle lastToggle;                       // 上一次选择的 Toggle

    private void Start()
    {
        ChildToggle = skillToggleGroup.GetComponentsInChildren<Toggle>();   // 获取所有的 Toggle
        skillDescriptionText = otherObj.GetComponent<RWJsonSkill>();     // 获取 TestJsonSkill 组件

        foreach (Toggle toggle in ChildToggle)
        {
            toggle.onValueChanged.AddListener(delegate
            {
                ToggleStateChanged(toggle);    // 为每个 Toggle 添加监听器
            });
        }
    }
    // 监听 Toggle 状态改变的方法
    void ToggleStateChanged(Toggle changedToggle)
    {
        GetChangerToggleName();
        if (changedToggle.isOn)
        {
            if (lastToggle != null && lastToggle == changedToggle)
            {
                return;   // 如果上一次选择的 Toggle 和当前选择的 Toggle 相同，则不进行处理
            }
            skillDescriptionText.UpdateSkillDescription(changedToggle.name,  GetChangerToggleName());   // 更新技能描述文本
//            Debug.Log("changedToggle.name="+changedToggle.name);
            lastToggle = changedToggle;   // 更新上一次选择的 Toggle
        }
    }
    public string GetChangerToggleName( )
    {
 //       Debug.Log("this.gameObject.name = "+this.gameObject.name);
        return this.gameObject.name;
    }
}