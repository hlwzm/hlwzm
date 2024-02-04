using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestoryObj : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Button>().onClick.AddListener(DestroyMyObj);
    }

    private void DestroyMyObj()
    {
        Destroy(obj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
