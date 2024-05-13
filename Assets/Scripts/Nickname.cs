using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nickname : MonoBehaviour
{
    public Text nicknameText;

    private void Start()
    {
        string nickname = PlayerPrefs.GetString("Nickname");
        nicknameText.text = nickname;
    }
}
