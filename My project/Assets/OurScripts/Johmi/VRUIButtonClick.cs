using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VRUIButtonClick : MonoBehaviour
{
    [SerializeField] private Button button;
    public void VRUnityUIButtonInvoke()
    {
        button.onClick.Invoke();
    }
}
