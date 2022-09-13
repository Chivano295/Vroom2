using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovingPlatforms : MonoBehaviour
{
    [SerializeField]
    public float platformMovementSpeed = 2;
    void Update()
    {
        transform.Translate(Vector3.right * platformMovementSpeed * Time.deltaTime);
    }
}

