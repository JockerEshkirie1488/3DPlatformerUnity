using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int damagePlayer = 2;
    public Transform target;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }
    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.DamagePlayer(damagePlayer);
    }
}
