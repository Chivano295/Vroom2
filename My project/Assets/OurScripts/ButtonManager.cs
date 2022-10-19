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
        if(!Truck.Illegal)
         StartCoroutine(Passing());
        if (Truck.Illegal)
            StartCoroutine(PassFail());
               
    }
    public void fails()
    {
        if (Truck.Illegal)
            StartCoroutine(Fail());
        if (!Truck.Illegal)
            StartCoroutine(FailPass());

    }
    public IEnumerator Passing()
    {
        Debug.Log("this works");
        win.Play();
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
        win.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("mainmenu");

    }

    public IEnumerator FailPass()
    {
        fail.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("mainmenu");
    }
}
