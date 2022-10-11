using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenClicker : MonoBehaviour
{
    [SerializeField] private GameObject _raycastObject;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit objectHit;
            Vector3 fwd = _raycastObject.transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(_raycastObject.transform.position, fwd, out objectHit, 100))
            {
                if (objectHit.transform.GetComponent<VRUIButtonClick>() != null)
                    objectHit.transform.GetComponent<VRUIButtonClick>().VRUnityUIButtonInvoke();
            }
        }
    }
}
