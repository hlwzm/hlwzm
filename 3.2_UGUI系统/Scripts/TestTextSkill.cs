using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestTextSkill : MonoBehaviour
{
    public TMP_Text TextSkillTrans;

    public void TextSkillDescriptionDisplay()
    {
        TextSkillTrans = this.gameObject.GetComponentInChildren<TMP_Text>();

        if (TextSkillTrans != null)
        {
            RefreshDisplay();
        }
        else
        {
            Debug.Log("未找到TMP_Text组件");
        }
    }
    void RefreshDisplay()
    {
        TextSkillTrans.text = "S1技能描述,魔法+10，攻击+15";
    }
    private void Update()
    {
        RefreshDisplay();
    }
}