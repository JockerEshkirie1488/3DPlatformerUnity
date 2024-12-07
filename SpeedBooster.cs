using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour
{
    public float speedBoost = 3.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed *= speedBoost;
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedBoost;
    }
    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().speed /= speedBoost;
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedBoost;
    }
}