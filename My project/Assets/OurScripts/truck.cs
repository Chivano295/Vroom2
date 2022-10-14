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

        Debug.Log(randoomnmbr);
        if (randoomnmbr > 5)
        {
            isTrue = true;

        }
        else
        {
            isTrue = false;
            currentscript = scriptables[Random.Range(0, 9)];
            realLicense.text = ("" + currentscript.license);
            fakeLicense.text = ("" + currentscript.license);
        }
        if (isTrue)
        {
            Illegal = true;           
            currentscript = scriptables[Random.Range(0, 9)];
            randoomnmbr = 0;
            realLicense.text = ("" + currentscript.license);           
        }
       //sets the text on the truck
        if(Illegal == true)
        {
            fakeLicense.text = ("" + currentscript.fakeLicense);
        }
        
        
            
        
    }
}
