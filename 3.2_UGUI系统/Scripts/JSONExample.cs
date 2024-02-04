//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.IO;

//[System.Serializable]
//public class Skill
//{
//    public string name;
//    public string description;
//    public int damage;
//    public int manaCost;
//}

//[System.Serializable]
//public class SkillsData
//{
//    public List<Skill> skills;
//}

//public class JSONExample
//{
//    void Start()
//    {
//        // ���� JSON ����
//        Skill fireball = new Skill();
//        fireball.name = "Fireball";
//        fireball.description = "Launches a fireball that deals damage to a single target.";
//        fireball.damage = 50;
//        fireball.manaCost = 10;

//        Skill heal = new Skill();
//        heal.name = "Heal";
//        heal.description = "Restores health to a target ally.";
//        heal.damage = 0;
//        heal.manaCost = 15;

//        Skill thunderstorm = new Skill();
//        thunderstorm.name = "Thunderstorm";
//        thunderstorm.description = "Summons a powerful thunderstorm that damages all enemies.";
//        thunderstorm.damage = 80;
//        thunderstorm.manaCost = 20;

//        List<Skill> skills = new List<Skill>();
//        skills.Add(fireball);
//        skills.Add(heal);
//        skills.Add(thunderstorm);

//        SkillsData data = new SkillsData();
//        data.skills = skills;

//        // ת�� JSON
//        string jsonData = JsonUtility.ToJson(data);
//        Debug.Log("JSON Data: " + jsonData);

//        // �Զ���·��
//        string customPath = "D:/LearnUnity/LearnUnityLesson/Lesson1/LearnUnityLesson1/Assets/Json/skillsData.json";

//        // �� JSON ����д���Զ���·��
//        File.WriteAllText(customPath, jsonData);

//        // ��ȡ�Զ���·���� JSON ����
//        string loadedJsonData = File.ReadAllText(customPath);
//        SkillsData loadedData = JsonUtility.FromJson<SkillsData>(loadedJsonData);

//        foreach (Skill skill in loadedData.skills)
//        {
//            Debug.Log("Name: " + skill.name);
//            Debug.Log("Description: " + skill.description);
//            Debug.Log("Damage: " + skill.damage);
//            Debug.Log("Mana Cost: " + skill.manaCost);
//        }
//        Debug.Log(customPath);
//    }
//}