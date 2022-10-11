using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class truck : MonoBehaviour
{
    int randoomnmbr;
    bool isTrue = false;
    public bool Illegal = false;

    public TextMeshPro realLicense;
    public TextMeshPro fakeLicense;
    public ScriptableLicense[] scriptables;
    public ScriptableLicense currentscript;

    public void Start()
    {
        Gen();
    }
    public void Update()
    {
         
    }

    public void Gen()
    {
        randoomnmbr = Random.Range(1, 10);
        
        if (randoomnmbr > 1)
        {
            isTrue = true;

        }
        else
        {
            isTrue = false;
        }
        if (isTrue)
        {
            Illegal = true;
            Debug.Log("Dit werkt");
            currentscript = scriptables[Random.Range(0, 10)];
            randoomnmbr = 0;
            realLicense.text = ("" + currentscript.license);           
        }
       //sets the text on the truck
        if(Illegal == true)
        {
            fakeLicense.text = ("" + currentscript.fakeLicense);
        }
        else
        {
            fakeLicense.text = ("" + currentscript.license);
        }
    }
}
