using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Penguin,
    Wizzard
}

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;
    public static Character selectedCharacter;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            return;
        }
        DontDestroyOnLoad(gameObject);
    }
}
