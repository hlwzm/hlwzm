using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VolumeTextOut : MonoBehaviour
{
    public TMP_Text inputOutText;   //����һ���ı�����
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

        inputOutText.text = this.gameObject.GetComponentInParent<Slider>().value.ToString();
        
    }
}
