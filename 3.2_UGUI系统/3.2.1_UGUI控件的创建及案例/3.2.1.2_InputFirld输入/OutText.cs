using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class OutText : MonoBehaviour
{


    public TMP_Text inputOutText;   //����һ���ı�����
    void Start()
    {
  

    }
    void Update()
    {
        inputOutText.text = this.gameObject.GetComponentInParent<InputField>().GetComponent<InputField>().password.text;
    }
}
