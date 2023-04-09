using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloblEvent : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            Exit();
        }

        if(Input.GetKeyDown(KeyCode.P)) {
            Debug.Log("Pause");
            Pause();
        }

        if(Input.GetKeyDown(KeyCode.R)) {
            Debug.Log("Resume");
            Resume();
        }

    }

    private void Exit() {
        Application.Quit();
    }

    private void Pause() {
        Time.timeScale = 0;
    }

    private void Resume() {
        Time.timeScale = 1;
    }
}
