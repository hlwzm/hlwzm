//using System.Collections.Generic;
//using UnityEngine;

//[System.Serializable]
//public class Character
//{
//    public string name;
//    public List<MySkill> mySkills;
//}

//[System.Serializable]
//public class MySkill
//{
//    public string name;
//    public string description;
//    public int damage;
//    public int manaCost;
//}

//[System.Serializable]
//public class Characters
//{
//    public List<Character> characters;
//}

//public class TestRWJson : MonoBehaviour
//{
//    private void Start()
//    {
//        // �� JSON �ļ��м�������
//        string customPath = "D:/LearnUnity/LearnUnityLesson/Lesson1/LearnUnityLesson1/Assets/Json/Test.json";  // �Զ���·��
//        string jsonText = System.IO.File.ReadAllText(customPath);
//        Characters characters = JsonUtility.FromJson<Characters>(jsonText);

//        // ʹ������
//        string description = characters.characters[0].mySkills[0].description;
//        Debug.Log(description);
//        Debug.Log("characters.characters[0].name=" + characters.characters[0].name);
//        Debug.Log("characters.characters[0].mySkills[0].name=" + characters.characters[0].mySkills[0].name);
//        Debug.Log("characters.characters[0].mySkills[1].name=" + characters.characters[0].mySkills[1].name);

//    }
//}