
using System.Collections.Generic;
using System.IO;
using UnityEngine;


namespace SkillIndo
{
    //[System.Serializable]
    //public class Skill
    //{
    //    public string name;         // ��������
    //    public string description;  // ��������
    //    public int damage;          // �����˺�ֵ
    //    public int manaCost;        // ����ħ������ֵ
    //}

    //[System.Serializable]
    //public class SkillsData
    //{
    //    public List<Skill> skills;  // �����б�
    //}

    [System.Serializable]
    public class Character
    {
        public string name;
        public List<Skill> mySkills;
    }

    [System.Serializable]
    public class Skill
    {
        public string name;
        public string description;
        public int damage;
        public int manaCost;
    }

    [System.Serializable]
    public class Characters
    {
        public List<Character> characters;
    }
}
