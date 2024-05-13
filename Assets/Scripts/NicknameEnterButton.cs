using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NicknameEnterButton : MonoBehaviour
{
    public InputField nicknameInput;
    public string nickname;

    public void StartGame()
    {
        nickname = nicknameInput.text;

        if (nickname.Length >=2 && nickname.Length <=10)
        {
            PlayerPrefs.SetString("Nickname", nickname);

            SceneManager.LoadScene("MainScene");
        }
    }
}
