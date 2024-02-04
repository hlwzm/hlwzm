using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

namespace SkillIndo
{
    public class TestRWJson : MonoBehaviour
    {
        //private void Start()
        //{
        //    // 从 JSON 文件中加载数据
        //    string customPath = "D:/LearnUnity/LearnUnityLesson/Lesson1/LearnUnityLesson1/Assets/Json/SkillData.json";  // 自定义路径
        //    string jsonText = File.ReadAllText(customPath);
        //    Characters characters = JsonUtility.FromJson<Characters>(jsonText);

        //    // 使用数据
        //    string description = characters.characters[0].mySkills[0].description;
        //    Debug.Log(description);
        //    Debug.Log("characters.characters[0].name=" + characters.characters[0].name);
        //    Debug.Log("characters.characters[0].mySkills[0].name=" + characters.characters[0].mySkills[0].name);
        //    Debug.Log("characters.characters[0].mySkills[1].name=" + characters.characters[0].mySkills[1].name);

        //    Debug.Log("characters.characters[1].name=" + characters.characters[1].name);
        //    Debug.Log("characters.characters[1].mySkills[2].name=" + characters.characters[1].mySkills[2].name);
        //    Debug.Log("characters.characters[1].mySkills[4].name=" + characters.characters[1].mySkills[4].name);
        //}
        private void Start()
        {
            string customPath = "D:/LearnUnity/LearnUnityLesson/Lesson1/LearnUnityLesson1/Assets/Json/SkillData.json";  // 自定义路径
            string json = File.ReadAllText(customPath); // 从文件中读取JSON数据
            Characters characters = JsonConvert.DeserializeObject<Characters>(json); // 将JSON数据转换为对象

            foreach (Character character in characters.characters)
            {
                Debug.Log("Character: " + character.name);

                foreach (Skill skill in character.mySkills)
                {
                    Debug.Log("Skill: " + skill.name);
                    Debug.Log("Description: " + skill.description);
                    Debug.Log("Damage: " + skill.damage);
                    Debug.Log("Mana Cost: " + skill.manaCost);
                }
            }
        }
    }
}
   