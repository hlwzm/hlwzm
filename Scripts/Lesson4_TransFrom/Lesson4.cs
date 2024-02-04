using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //空间点的坐标（x,y,z）
    Vector3 v1 = new Vector3(4,5,6);
    Vector3 v2 = new Vector3(7,8,9);
    // Start is called before the first frame update
    void Start()
    {

        print(v1);
        //世界坐标轴的朝向
        print(Vector3.zero);//0,0,0
        print(Vector3.right);//1,0,0
        print(Vector3.left);//-1,0,0
        print (Vector3.forward);//0,0,1
        print(Vector3.back);//0,0,-1
        print(Vector3.up);//0,1,0
        print(Vector3.down);//0,-1,0

        print(Vector3 .Distance(v1,v2));//两点距离
        print(this.transform.position);//相对世界坐标系的位置，注意有无父对象
        //相对于父对象的坐标，当父对象的坐标为世界坐标的原点时，子对象的position = localPosition
        print(this.transform.localPosition);
        this.transform.position = new Vector3(10,10,10);

        Vector3 vPos = this.transform.position;
        vPos.x = 20;//先取出再单独修改某一坐标位置
        this.transform.position = vPos;

        //对象自己的面朝向
       print( this.transform.forward);

        this.transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
       // this.transform.position = this.transform.position + this.transform.forward * 2 * Time.deltaTime;
     //   this.transform.position += this.transform.forward * 2 * Time.deltaTime;//朝自己的forward运动
       // this.transform.position += Vector3.forward * 2 * Time.deltaTime;//朝世界方向的forward运动
        //库函数方法移动，朝自己的forward运动
        this.transform.Translate(Vector3.forward*1*Time.deltaTime,Space.Self);
        this.transform.Rotate(new Vector3(20, 20, 0) * Time.deltaTime);
       
    }
}
