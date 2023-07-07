using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI points;
    public TextMeshProUGUI enemiesKilledText;
    public TextMeshProUGUI HitEnemyText;
    public TextMeshProUGUI AccuracyText;
    public TextMeshProUGUI TimeGameText;

    public Score Score;
    public Bullet Bullet;
    public Enemy Enemy;
    public Timer Timer;

    public void Start()
    {
        UpdateEndScreen();
    }

    public void UpdateEndScreen()
    {
        int score = Score.scoreValue;
        int enemiesKilled = Enemy.enemiesKilled;
        int bulletCount = Bullet.bulletCount;
        float accuracy = Bullet.hitBulletCount;

        points.text = "Punkty: " + score;
        enemiesKilledText.text = "Zabici wrogowie: " + enemiesKilled.ToString();
        AccuracyText.text = "Celnosc: " + accuracy.ToString();
        HitEnemyText.text = "Pociski: " + bulletCount.ToString();
        TimeGameText.text = "Czas: " + Timer.timeString2;
    }

    
}
