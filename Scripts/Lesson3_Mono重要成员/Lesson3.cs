using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    public Lesson3 otherLesson3;
    // Start is called before the first frame update
    void Start()
    {
        
        print(this.gameObject.name);//获取自身脚本依附的对象的名字
        //获取依附对象的位置
        print (this.transform.position);//  与print(this.gameObject .transform .position );相同
        print(this.transform.eulerAngles);
        print(this.transform.lossyScale);
        //获取自身脚本的激活与失活
     //   this.enabled = false;

        //获取别的脚本对象依附的gameobject
        print(otherLesson3.gameObject.name);

        //通过脚本名获取挂载的其它脚本
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
