using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    
    public int i1 =5;
    [HideInInspector] public bool b = true;    //HideInInspector���ع�������ʾ��Inspector���
                                               
  //  [SerializeField] private int i2 =10;//�����Ժ�˽�кͱ����ı����Ϳ�����Inspecto������ʾ�ҿɱ༭
    [SerializeField] protected string str = "123";
    public enum E_TestEnum
    { 
        Normal,
        Player,
        Monster
    }
    [System.Serializable]//ʹ�Զ����������Inspector�����ʾ
    public class Myclass
    { 
        public int i;
        public int j;
    }
    public Dictionary <int,string >dic = new Dictionary <int,string> ();
    public int[]arr = null;
    public List<int> list = new List<int>();
    public E_TestEnum type;
    public GameObject gameobj;
    public Myclass myclass;
    [Header("����")]
    [Range (0,20)]
    public int atk;
    public int atk2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
