using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damageToGive = 1;
    public static int bulletCount = 0;
    public static int hitBulletCount = 0;

    public GameObject bulletParticlePrefab;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        bulletCount++;

        Instantiate(bulletParticlePrefab, transform.position, Quaternion.identity);

        if(collision.gameObject.tag == "Enemy")
        {
            hitBulletCount++;
            collision.gameObject.GetComponent<Enemy>().hurtEnemy(damageToGive); 
        }
    }
}
