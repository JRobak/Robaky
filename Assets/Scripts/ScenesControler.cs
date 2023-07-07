using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesControler : MonoBehaviour
{
    public Enemy Enemy;
    public Bullet Bullet;

    public void changeScenes()
    {
        SceneManager.LoadScene(1);
        Enemy.enemiesKilled = 0;
        Bullet.bulletCount = 0;
        Bullet.hitBulletCount = 0;
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void gameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void exit()
    {
        Application.Quit();
    }
}
