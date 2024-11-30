using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Vector3 tpCoords;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Transform>().position = tpCoords;
    }
}
