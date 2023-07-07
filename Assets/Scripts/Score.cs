using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int scoreValue;
    public TextMeshProUGUI myText;

    void Start()
    {
        myText = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
    }

    void Update()
    {
        myText.text = "Score: " + scoreValue;
    }
}
