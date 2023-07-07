using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int damageToGive;
    public float damageInterval = 1f;
    private float timeSinceLastDamage = 0f;

    public HealthSystem healthSystem;
    public Transform player;

    public GameObject hurtPlayerSound;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        healthSystem = GameObject.Find("Player").GetComponent<HealthSystem>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            healthSystem.Damage(damageToGive);
            GameObject hurtPlayerSoundObj = Instantiate(hurtPlayerSound, transform.position, Quaternion.identity);
            Destroy(hurtPlayerSoundObj, 1f);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timeSinceLastDamage += Time.deltaTime;
            if (timeSinceLastDamage >= damageInterval)
            {
                healthSystem.Damage(damageToGive);
                timeSinceLastDamage = 0f;
                GameObject hurtPlayerSoundObj = Instantiate(hurtPlayerSound, transform.position, Quaternion.identity);
                Destroy(hurtPlayerSoundObj, 1f);
            }
        }
    }
}
