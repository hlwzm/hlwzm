using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }
    ////�������Ķ��󼤻�ʱ����
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
    //������������ĸ��£�����Updateִ��
    private void LateUpdate()
    {
        print("LateUpdate");
    }
    //�������Ķ���ʧ��ʱ����
    private void OnDisable()
    {
        print("OnDisabl");
    }
    //����ɾ��ʱ����
    private void OnDestroy()
    {
        print("OnDestroy");
    }

}
