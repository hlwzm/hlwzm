using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
3.2.3   Image
����һ��Image�ؼ���ȡ��ΪImageBack���ٴ���һ��Image��������ΪImageBack���ӿؼ�
��Ϊ�����ؼ����������ɫ��ǳ��һ����ͼƬ���½�һ���ű�ImageTest,����������ӿؼ�Image�ϣ�
����Image��ҷ���ű�ImageTest�еı�����
*/
public class ImageTest : MonoBehaviour
{
    public Image image;
    float restTime = 12f;//����ʣ��ʱ��
    float coodDownTime = 12f;//������ȴʱ��
    void Start()
    {
        image = this.GetComponent<Image>();
    }
    void Update()
    {
        if (restTime > 0)
        {
            restTime -= Time.deltaTime;
            image.fillAmount = restTime / coodDownTime;
        }
        if (restTime < 0)
        {
            restTime = 12;
        }
    }
}
