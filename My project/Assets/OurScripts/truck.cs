using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class truck : MonoBehaviour
{
    int randoomnmbr;
    bool isFake = false;

    public TextMeshPro realLicense;
    public TextMeshPro fakeLicense;
    public ScriptableObject[] scriptables;
    public ScriptableObject currentscript;

    public void Start()
    {
        Gen();
    }
    public void Update()
    {
       

        if (isFake)
        {
            Debug.Log("Dit werkt");
            currentscript = scriptables[Random.Range(0, 10)];
            randoomnmbr = 0;
        }
    }

    public void Gen()
    {
        randoomnmbr = Random.Range(1, 10);
        
        if (randoomnmbr > 1)
        {
            isFake = true;

        }
        else
        {
            isFake = false;
        }
    }
}
