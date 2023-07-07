using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool timerIsRunning = false;
    public TextMeshPro timeText;
    public string timeString;
    public static string timeString2;
    public float gameTime = 0f;

    void Start()
    {
        // Set the timerIsRunning flag to true and get the time when the script starts
        timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            gameTime += Time.deltaTime;
            DisplayTime(gameTime);
        }
        timeString2 = timeString;
    }

    void DisplayTime(float timeToDisplay)
    {
        // Format the time remaining as a string with minutes and seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeString = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Update the UI text component with the formatted time
        timeText.text = "Czas: " + timeString;
    }
}
