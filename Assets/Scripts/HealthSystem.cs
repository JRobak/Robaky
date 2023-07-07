using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int healthMax;

    public HealthBar healthBar;
    public enemySpawner enemySpawn;

    public AudioSource playerDeath;

    void Start()
    {
        health = healthMax;
        healthBar.SetMaxHealth(healthMax);
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount; 

        if(health <= 0)
        {
            
            SceneManager.LoadScene(2);

            Destroy(gameObject);
        }

        healthBar.SetHealth(health);
    }
}
