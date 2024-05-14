using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    public Text timeText;

    private void Start()
    {
        DateTime now = DateTime.Now;

        string hour = now.Hour.ToString("00");
        string minute = now.Minute.ToString("00");

        timeText.text = hour + ":" + minute;
    }
}
