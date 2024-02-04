using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Vector3.forward);
        //相当于有两个坐标系，一个世界坐标系，一个以自己为原点的坐标系，方向和原点位置可能不同
        print("世界坐标转本地坐标"+this.transform.InverseTransformDirection(new Vector3(1,0,1)));
        //本地点转世界坐标
        print(this.transform .TransformPoint(new Vector3 (1,0,1)));//受缩放影响
        print(this.transform.TransformDirection(new Vector3(1, 0, 1)));//不受缩放影响
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
