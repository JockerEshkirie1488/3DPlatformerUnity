using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float speedRotate = 100f;
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Player>().coins += 1;
        Destroy(this.gameObject);
    }
    void Update()
    {
        transform.Rotate(0, speedRotate*Time.deltaTime, 0);
    }
}
