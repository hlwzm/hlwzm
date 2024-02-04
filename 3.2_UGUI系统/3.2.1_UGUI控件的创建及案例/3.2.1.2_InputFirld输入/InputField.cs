using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputField : MonoBehaviour
{
    public TMP_InputField password;
    // Start is called before the first frame update
    void Start()
    {
        password.contentType = TMP_InputField.ContentType.Password;
    }
    private void Update()
    {
    //    print(password.text);//*********¥Ú”° ‰»Îµƒ√‹¬Î
    }
    public void OutText()
    { 
        
    }
}
