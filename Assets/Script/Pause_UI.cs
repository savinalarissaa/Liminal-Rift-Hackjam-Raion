using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_UI : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool isPaused = false;

    private void Start()
    {
        Resume();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) Resume();
            else if (!isPaused) Pause();
        }
    }

    public void Pause()
    {
        pauseScreen.gameObject.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        pauseScreen.gameObject.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
