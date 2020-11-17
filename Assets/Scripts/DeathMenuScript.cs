﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenuScript : MonoBehaviour
{
    public void DeathRetry()
    {
        Debug.Log("Retry button clicked");
    }

    public void DeathQuit()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }
}