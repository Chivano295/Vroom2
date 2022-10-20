using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public truck Truck;
    public AudioSource win;
    public AudioSource fail;
    public void Pass()
    {
        if (!Truck.Illegal)
        {
            win.Play();
            StartCoroutine(Passing());
        }
        
        if (Truck.Illegal)
        {
            fail.Play();
            StartCoroutine(PassFail());
        }
           
               
    }
    public void fails()
    {
        if (Truck.Illegal)
        {
            StartCoroutine(Fail());
            win.Play();
        }
            
        if (!Truck.Illegal)
        {
            StartCoroutine(FailPass());
            fail.Play();
        }
          

    }
    public IEnumerator Passing()
    {
        Debug.Log("this works");
        
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("mainmenu");

    }
     
    public IEnumerator PassFail()
    {
        fail.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("mainmenu");
    }
    public IEnumerator Fail()
    {
        Debug.Log("this works");
     
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("mainmenu");

    }

    public IEnumerator FailPass()
    {
       
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("mainmenu");
    }
}
