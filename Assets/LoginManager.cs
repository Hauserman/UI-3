using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{

    public InputField InputPassword;
    public string Password = "Manzana";

    public void OnClick()
    {
        if (InputPassword.text == Password)
        {
            Debug.Log("Acces granted");
        }
        else
        {
            Debug.Log("Acces denied");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
