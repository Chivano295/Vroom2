using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoucingPlatformHitboxScript : MonoBehaviour
{
    [SerializeField]
    public BouncingPlatformScript bouncingPlatforms;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            bouncingPlatforms.platformMovementSpeedRight = bouncingPlatforms.platformMovementSpeedRight * -1;
        }
        if (other.gameObject.CompareTag("Roof"))
        {
            bouncingPlatforms.platformMovementSpeedUp = bouncingPlatforms.platformMovementSpeedUp * -1;
        }
    }
}
