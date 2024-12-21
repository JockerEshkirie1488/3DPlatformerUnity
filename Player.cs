using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 30;
    public int coins = 0;
    public string sceneName;
    public Transform attackPoint;
    public GameObject fireballPrefab;
    public AudioSource audioSource;
    public AudioClip damageSound;

    public void DamagePlayer(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            EditorSceneManager.LoadScene(sceneName);
        }
        else
        {
            audioSource.PlayOneShot(damageSound);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
