using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformHitbox : MonoBehaviour
{
    [SerializeField]
    public MovingPlatforms movingPlatforms;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            movingPlatforms.platformMovementSpeed = movingPlatforms.platformMovementSpeed * -1;
        }
    }
}
