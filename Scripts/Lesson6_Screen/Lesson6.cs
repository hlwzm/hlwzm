using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()

    {
        Resolution r = Screen.currentResolution;//获取屏幕分辨率
        print("宽"+r.width+"高"+r.height);
        print("宽"+Screen.width);//Game窗口
        print("高" + Screen.height);

        Screen.sleepTimeout = 0;
        Screen.fullScreenMode = FullScreenMode.Windowed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
