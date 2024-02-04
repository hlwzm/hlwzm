using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    ////被依附的对象激活时调用
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }

    // Update is called once per frame
    void Update()
    {
        print("Update");
    }
    //常用于摄像机的更新，晚于Update执行
    private void LateUpdate()
    {
        print("LateUpdate");
    }
    //被依附的对象失活时调用
    private void OnDisable()
    {
        print("OnDisabl");
    }
    //对象被删除时调用
    private void OnDestroy()
    {
        print("OnDestroy");
    }

}
