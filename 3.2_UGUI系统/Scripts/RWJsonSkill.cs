using UnityEngine;
using UnityEngine.UI;
using System.IO;
using SkillIndo;
using static RoleControSkill;

public class RWJsonSkill : MonoBehaviour
{
    public Text TextSkillTrans;          // ������ʾ���������� TMP_Text ���
    static private Characters skillsData;    // ��������
  //  public GameObject otherRoleObj;

    //Characters characters = JsonUtility.FromJson<Characters>(jsonText);
    static private string currentSkillName = "";  // ��ǰѡ�еļ�������
    static private string RoleSkillName = "";  // ��ǰѡ�еļ�������

    void Start()
    {
        //    TextSkillTrans = this.gameObject.GetComponentInChildren<Text>();  // ��ȡ Text ���

        if (TextSkillTrans != null)
        {
            LoadSkillsDataFromJSON();   // �� JSON �ļ����ؼ�������
            RefreshDisplay();           // ˢ����ʾ������Ϣ
        }
        else
        {
            Debug.LogWarning("δ�ҵ�TMP_Text���123");
        }
    }

    // �� JSON �ļ����ؼ�������
    void LoadSkillsDataFromJSON()
    {
        string customPath = "D:/LearnUnity/LearnUnityLesson/Lesson1/LearnUnityLesson1/Assets/Json/SkillData.json";  // �Զ���·��
        string jsonData = File.ReadAllText(customPath);  // ��ȡ JSON ����
      //  Debug.Log(jsonData);
        skillsData = JsonUtility.FromJson<Characters>(jsonData);  // �����л� JSON ���ݵ� SkillsData ����
                                                                  //Characters characters = JsonUtility.FromJson<Characters>(jsonText);
        Skill skill = skillsData.characters[1].mySkills[0];  // ��ȡ��һ������
        TextSkillTrans.text = "�������ƣ�" + skill.name + "\n����������" + skill.description + "\nħ����" + skill.manaCost + "\n������" + skill.damage;  // �����ı���ʾ
    }

    // ˢ����ʾ������Ϣ
    void RefreshDisplay()
    {
        if (TextSkillTrans != null && skillsData != null && skillsData.characters.Count > 0)
        {
            Skill skill = skillsData.characters[1].mySkills[0];  // ��ȡ��һ������
            TextSkillTrans.text = "�������ƣ�" + skill.name+"\n����������" + skill.description + "\nħ����" + skill.manaCost + "\n������" + skill.damage;  // �����ı���ʾ
        }
        else
        {
            Debug.LogWarning("�޷���JSON�����ж�ȡ������Ϣ");
        }
    }
    // ���¼�������
    public void UpdateSkillDescription(string sskillNum,string otherObjName)
    {
        if (TextSkillTrans != null && skillsData != null && skillsData.characters.Count > 0)
        {
            if (otherObjName == "AssassinRoleSkills(Clone)")
            {
                Skill skill = skillsData.characters[0].mySkills.Find(s => s.name == sskillNum);  // ��������ѡ��������ƥ��ļ���
                if (skill != null)
                {
                    TextSkillTrans.text = "�������ƣ�" + skill.name + "\n����������" + skill.description + "\nħ����" + skill.manaCost + "\n������" + skill.damage;  // �����ı���ʾ
                    currentSkillName = sskillNum;   // ���µ�ǰ��������
                    RoleSkillName = otherObjName;
                }
                else
                {
                    Debug.LogWarning("δ�ҵ�ƥ��ļ���");
                }
            }
            else if (otherObjName == "ElementalistRoleskills(Clone)")
            {
                Skill skill = skillsData.characters[1].mySkills.Find(s => s.name == sskillNum);  // ��������ѡ��������ƥ��ļ���
                if (skill != null)
                {
                    TextSkillTrans.text = "�������ƣ�" + skill.name + "\n����������" + skill.description + "\nħ����" + skill.manaCost + "\n������" + skill.damage;  // �����ı���ʾ
                    currentSkillName = sskillNum;   // ���µ�ǰ��������
                    RoleSkillName = otherObjName;
                }
                else
                {
                    Debug.LogWarning("δ�ҵ�ƥ��ļ���");
                }
            }
            else if (otherObjName == "HolyDarknessRoleskills(Clone)")
            {
                Skill skill = skillsData.characters[2].mySkills.Find(s => s.name == sskillNum);  // ��������ѡ��������ƥ��ļ���
                if (skill != null)
                {
                    TextSkillTrans.text = "�������ƣ�" + skill.name + "\n����������" + skill.description + "\nħ����" + skill.manaCost + "\n������" + skill.damage;  // �����ı���ʾ
                    currentSkillName = sskillNum;   // ���µ�ǰ��������
                    RoleSkillName = otherObjName;
                }
                else
                {
                    Debug.LogWarning("δ�ҵ�ƥ��ļ���");
                }
            }
            else if (otherObjName == "SymbioseRoleskills(Clone)")
            {
                Skill skill = skillsData.characters[3].mySkills.Find(s => s.name == sskillNum);  // ��������ѡ��������ƥ��ļ���
                if (skill != null)
                {
                    TextSkillTrans.text = "�������ƣ�" + skill.name + "\n����������" + skill.description + "\nħ����" + skill.manaCost + "\n������" + skill.damage;  // �����ı���ʾ
                    currentSkillName = sskillNum;   // ���µ�ǰ��������
                    RoleSkillName = otherObjName;
                }
                else
                {
                    Debug.LogWarning("δ�ҵ�ƥ��ļ���");
                }
            }
            
            else if (otherObjName == "WarriorRoleskills(Clone)")
            {
                Skill skill = skillsData.characters[4].mySkills.Find(s => s.name == sskillNum);  // ��������ѡ��������ƥ��ļ���
                if (skill != null)
                {
                    TextSkillTrans.text = "�������ƣ�" + skill.name + "\n����������" + skill.description + "\nħ����" + skill.manaCost + "\n������" + skill.damage;  // �����ı���ʾ
                    currentSkillName = sskillNum;   // ���µ�ǰ��������
                    RoleSkillName = otherObjName;
                }
                else
                {
                  Debug.LogWarning("δ�ҵ�ƥ��ļ���");
                }
            }
            else
            {
                Debug.LogWarning("��ɫ����ƥ��");
            }
        }
    }
    void Update()
    {
        if (currentSkillName != "")
        {
            UpdateSkillDescription(currentSkillName, RoleSkillName);  // ʵʱ���¼�������
        }
    }
}