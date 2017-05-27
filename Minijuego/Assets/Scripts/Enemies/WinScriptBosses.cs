﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScriptBosses : MonoBehaviour
{
    public GameObject uI;
    public GameObject gameOver;
    int topMinutes;
    int topSeconds;
    private float startTime;
    private bool finished;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1f;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver.activeSelf)
        {
            return;
        }
        if (GameObject.Find("GameMaster").GetComponent<HealthBarScript>().health <= 0)
        {
            Finish();
        }
    }
    void Finish()
    {
        uI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
