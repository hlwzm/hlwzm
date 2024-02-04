using UnityEngine;
using UnityEngine.UI;
using System.IO;
using SkillIndo;
using static RoleControSkill;

public class RWJsonSkill : MonoBehaviour
{
    public Text TextSkillTrans;          // 用于显示技能描述的 TMP_Text 组件
    static private Characters skillsData;    // 技能数据
  //  public GameObject otherRoleObj;

    //Characters characters = JsonUtility.FromJson<Characters>(jsonText);
    static private string currentSkillName = "";  // 当前选中的技能名称
    static private string RoleSkillName = "";  // 当前选中的技能名称

    void Start()
    {
        //    TextSkillTrans = this.gameObject.GetComponentInChildren<Text>();  // 获取 Text 组件

        if (TextSkillTrans != null)
        {
            LoadSkillsDataFromJSON();   // 从 JSON 文件加载技能数据
            RefreshDisplay();           // 刷新显示技能信息
        }
        else
        {
            Debug.LogWarning("未找到TMP_Text组件123");
        }
    }

    // 从 JSON 文件加载技能数据
    void LoadSkillsDataFromJSON()
    {
        string customPath = "D:/LearnUnity/LearnUnityLesson/Lesson1/LearnUnityLesson1/Assets/Json/SkillData.json";  // 自定义路径
        string jsonData = File.ReadAllText(customPath);  // 读取 JSON 数据
      //  Debug.Log(jsonData);
        skillsData = JsonUtility.FromJson<Characters>(jsonData);  // 反序列化 JSON 数据到 SkillsData 对象
                                                                  //Characters characters = JsonUtility.FromJson<Characters>(jsonText);
        Skill skill = skillsData.characters[1].mySkills[0];  // 获取第一个技能
        TextSkillTrans.text = "技能名称：" + skill.name + "\n技能描述：" + skill.description + "\n魔法：" + skill.manaCost + "\n攻击：" + skill.damage;  // 更新文本显示
    }

    // 刷新显示技能信息
    void RefreshDisplay()
    {
        if (TextSkillTrans != null && skillsData != null && skillsData.characters.Count > 0)
        {
            Skill skill = skillsData.characters[1].mySkills[0];  // 获取第一个技能
            TextSkillTrans.text = "技能名称：" + skill.name+"\n技能描述：" + skill.description + "\n魔法：" + skill.manaCost + "\n攻击：" + skill.damage;  // 更新文本显示
        }
        else
        {
            Debug.LogWarning("无法从JSON数据中读取技能信息");
        }
    }
    // 更新技能描述
    public void UpdateSkillDescription(string sskillNum,string otherObjName)
    {
        if (TextSkillTrans != null && skillsData != null && skillsData.characters.Count > 0)
        {
            if (otherObjName == "AssassinRoleSkills(Clone)")
            {
                Skill skill = skillsData.characters[0].mySkills.Find(s => s.name == sskillNum);  // 查找与所选技能名称匹配的技能
                if (skill != null)
                {
                    TextSkillTrans.text = "技能名称：" + skill.name + "\n技能描述：" + skill.description + "\n魔法：" + skill.manaCost + "\n攻击：" + skill.damage;  // 更新文本显示
                    currentSkillName = sskillNum;   // 更新当前技能名称
                    RoleSkillName = otherObjName;
                }
                else
                {
                    Debug.LogWarning("未找到匹配的技能");
                }
            }
            else if (otherObjName == "ElementalistRoleskills(Clone)")
            {
                Skill skill = skillsData.characters[1].mySkills.Find(s => s.name == sskillNum);  // 查找与所选技能名称匹配的技能
                if (skill != null)
                {
                    TextSkillTrans.text = "技能名称：" + skill.name + "\n技能描述：" + skill.description + "\n魔法：" + skill.manaCost + "\n攻击：" + skill.damage;  // 更新文本显示
                    currentSkillName = sskillNum;   // 更新当前技能名称
                    RoleSkillName = otherObjName;
                }
                else
                {
                    Debug.LogWarning("未找到匹配的技能");
                }
            }
            else if (otherObjName == "HolyDarknessRoleskills(Clone)")
            {
                Skill skill = skillsData.characters[2].mySkills.Find(s => s.name == sskillNum);  // 查找与所选技能名称匹配的技能
                if (skill != null)
                {
                    TextSkillTrans.text = "技能名称：" + skill.name + "\n技能描述：" + skill.description + "\n魔法：" + skill.manaCost + "\n攻击：" + skill.damage;  // 更新文本显示
                    currentSkillName = sskillNum;   // 更新当前技能名称
                    RoleSkillName = otherObjName;
                }
                else
                {
                    Debug.LogWarning("未找到匹配的技能");
                }
            }
            else if (otherObjName == "SymbioseRoleskills(Clone)")
            {
                Skill skill = skillsData.characters[3].mySkills.Find(s => s.name == sskillNum);  // 查找与所选技能名称匹配的技能
                if (skill != null)
                {
                    TextSkillTrans.text = "技能名称：" + skill.name + "\n技能描述：" + skill.description + "\n魔法：" + skill.manaCost + "\n攻击：" + skill.damage;  // 更新文本显示
                    currentSkillName = sskillNum;   // 更新当前技能名称
                    RoleSkillName = otherObjName;
                }
                else
                {
                    Debug.LogWarning("未找到匹配的技能");
                }
            }
            
            else if (otherObjName == "WarriorRoleskills(Clone)")
            {
                Skill skill = skillsData.characters[4].mySkills.Find(s => s.name == sskillNum);  // 查找与所选技能名称匹配的技能
                if (skill != null)
                {
                    TextSkillTrans.text = "技能名称：" + skill.name + "\n技能描述：" + skill.description + "\n魔法：" + skill.manaCost + "\n攻击：" + skill.damage;  // 更新文本显示
                    currentSkillName = sskillNum;   // 更新当前技能名称
                    RoleSkillName = otherObjName;
                }
                else
                {
                  Debug.LogWarning("未找到匹配的技能");
                }
            }
            else
            {
                Debug.LogWarning("角色名不匹配");
            }
        }
    }
    void Update()
    {
        if (currentSkillName != "")
        {
            UpdateSkillDescription(currentSkillName, RoleSkillName);  // 实时更新技能描述
        }
    }
}