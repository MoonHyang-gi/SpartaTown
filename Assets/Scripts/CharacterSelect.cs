using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public Character character;
    public GameObject SelectWindow;

    private void OnMouseUpAsButton()
    {
        CharacterManager.selectedCharacter = character;
        SelectWindow.SetActive(false);
    }
}
