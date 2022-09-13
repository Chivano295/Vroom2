using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingPlatformScript : MonoBehaviour
{
    [SerializeField]
    public float platformMovementSpeedRight = 2;
    public float platformMovementSpeedUp = 2;
    void Update()
    {
        transform.Translate(Vector3.right * platformMovementSpeedRight * Time.deltaTime);
        transform.Translate(Vector3.up * platformMovementSpeedUp * Time.deltaTime);
    }
}
