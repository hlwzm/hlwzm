
using System.Collections.Generic;
using System.IO;
using UnityEngine;


namespace SkillIndo
{
    //[System.Serializable]
    //public class Skill
    //{
    //    public string name;         // 技能名称
    //    public string description;  // 技能描述
    //    public int damage;          // 技能伤害值
    //    public int manaCost;        // 技能魔法消耗值
    //}

    //[System.Serializable]
    //public class SkillsData
    //{
    //    public List<Skill> skills;  // 技能列表
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
