using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //�ռ������꣨x,y,z��
    Vector3 v1 = new Vector3(4,5,6);
    Vector3 v2 = new Vector3(7,8,9);
    // Start is called before the first frame update
    void Start()
    {

        print(v1);
        //����������ĳ���
        print(Vector3.zero);//0,0,0
        print(Vector3.right);//1,0,0
        print(Vector3.left);//-1,0,0
        print (Vector3.forward);//0,0,1
        print(Vector3.back);//0,0,-1
        print(Vector3.up);//0,1,0
        print(Vector3.down);//0,-1,0

        print(Vector3 .Distance(v1,v2));//�������
        print(this.transform.position);//�����������ϵ��λ�ã�ע�����޸�����
        //����ڸ���������꣬�������������Ϊ���������ԭ��ʱ���Ӷ����position = localPosition
        print(this.transform.localPosition);
        this.transform.position = new Vector3(10,10,10);

        Vector3 vPos = this.transform.position;
        vPos.x = 20;//��ȡ���ٵ����޸�ĳһ����λ��
        this.transform.position = vPos;

        //�����Լ����泯��
       print( this.transform.forward);

        this.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       // this.transform.position = this.transform.position + this.transform.forward * 2 * Time.deltaTime;
     //   this.transform.position += this.transform.forward * 2 * Time.deltaTime;//���Լ���forward�˶�
       // this.transform.position += Vector3.forward * 2 * Time.deltaTime;//�����緽���forward�˶�
        //�⺯�������ƶ������Լ���forward�˶�
        this.transform.Translate(Vector3.forward*1*Time.deltaTime,Space.Self);
        this.transform.Rotate(new Vector3(20, 20, 0) * Time.deltaTime);
       
    }
}
