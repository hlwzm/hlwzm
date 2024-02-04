using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    
    public int i1 =5;
    [HideInInspector] public bool b = true;    //HideInInspector隐藏公共不显示在Inspector面板
                                               
  //  [SerializeField] private int i2 =10;//加了以后私有和保护的变量就可以在Inspecto窗口显示且可编辑
    [SerializeField] protected string str = "123";
    public enum E_TestEnum
    { 
        Normal,
        Player,
        Monster
    }
    [System.Serializable]//使自定义类可以在Inspector面板显示
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
    [Header("分组")]
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
