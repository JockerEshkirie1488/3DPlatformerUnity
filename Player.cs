using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 20;
    public int coins = 0;
    public string sceneName;

    public void DamagePlayer(int damage)
    {
        health -= damage;
    }
    void Update()
    {
        if (health <= 0 || coins >= 15)
        {
            health = 20;
            coins = 0;
            EditorSceneManager.LoadScene(sceneName);
        }
        
    }
}
