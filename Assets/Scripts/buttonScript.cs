using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonScript : MonoBehaviour
{
    public GameObject button;

    void Start()
    {
        button.SetActive(false);
        Invoke("EnableButton", 2f);
    }

    void EnableButton()
    {
        button.SetActive(true);
    }
}
