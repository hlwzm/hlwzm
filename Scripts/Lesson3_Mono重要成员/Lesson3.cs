using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    public Lesson3 otherLesson3;
    // Start is called before the first frame update
    void Start()
    {
        
        print(this.gameObject.name);//��ȡ����ű������Ķ��������
        //��ȡ���������λ��
        print (this.transform.position);//  ��print(this.gameObject .transform .position );��ͬ
        print(this.transform.eulerAngles);
        print(this.transform.lossyScale);
        //��ȡ����ű��ļ�����ʧ��
     //   this.enabled = false;

        //��ȡ��Ľű�����������gameobject
        print(otherLesson3.gameObject.name);

        //ͨ���ű�����ȡ���ص������ű�
        Lesson3_Test t = this.GetComponent("Lesson3_Test") as Lesson3_Test;
        print(t);
        t = this.GetComponent (typeof(Lesson3_Test)) as Lesson3_Test;
        print(t);
        t = this.GetComponent<Lesson3_Test>();
        print(t);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
