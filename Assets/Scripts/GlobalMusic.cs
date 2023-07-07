using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalMusic : MonoBehaviour
{
    public static GlobalMusic instance; // singleton

    public AudioSource music; // referencja do komponentu AudioSource

    void Awake()
    {
        // sprawdź, czy istnieje już inny AudioManager, jeśli tak, zniszcz ten obiekt
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        // ustaw obecny obiekt jako singleton
        instance = this;

        // użyj DontDestroyOnLoad, aby zapobiec usuwaniu obiektu przy zmianie sceny
        DontDestroyOnLoad(this.gameObject);

    }
}
