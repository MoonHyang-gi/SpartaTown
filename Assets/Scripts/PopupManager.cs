using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject popup;
    public GameObject character1;
    public GameObject character2;
    private GameObject selectedCharacter;

    void Start()
    {
        popup.SetActive(false);
    }

    public void OpenPopup()
    {
        popup.SetActive(true);
    }

    public void ClosePopup()
    {
        popup.SetActive(false);
    }

    public void SelectCharacter1()
    {
        selectedCharacter = character1;
        ClosePopup();
    }

    public void SelectCharacter2()
    {
        selectedCharacter = character2;
        ClosePopup();
    }
}
