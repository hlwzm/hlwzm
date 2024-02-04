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
            Debug.Log("δ�ҵ�TMP_Text���");
        }
    }
    void RefreshDisplay()
    {
        TextSkillTrans.text = "S1��������,ħ��+10������+15";
    }
    private void Update()
    {
        RefreshDisplay();
    }
}