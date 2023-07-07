using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector2 movment;

    public GameObject deathParticlePrefab;

    public GameObject deathSound;

    public int hp;
    public int currentHp;
    public int pointsToGive;
    public static int enemiesKilled = 0;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentHp = hp;
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;

            direction.Normalize();
            movment = direction;

            if(currentHp <= 0)
            {
                Score.scoreValue += pointsToGive;
                enemiesKilled++;
                Destroy(gameObject);

                Instantiate(deathParticlePrefab, transform.position, Quaternion.identity);  

                GameObject deathSoundObj = Instantiate(deathSound, transform.position, Quaternion.identity);
                Destroy(deathSoundObj, 1f);
            }
        }
    }

    void FixedUpdate()
    {
        moveCharacter(movment);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
        moveSpeed = 0f; 
        Invoke("StartMoving", 0.5f); 
    }

    public void hurtEnemy(int damage)
    {
        currentHp -= damage;
    }

    void StartMoving()
    {
        moveSpeed = 5f; 
    }
}
