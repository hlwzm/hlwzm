using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()

    {
        Resolution r = Screen.currentResolution;//��ȡ��Ļ�ֱ���
        print("��"+r.width+"��"+r.height);
        print("��"+Screen.width);//Game����
        print("��" + Screen.height);

        Screen.sleepTimeout = 0;
        Screen.fullScreenMode = FullScreenMode.Windowed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
