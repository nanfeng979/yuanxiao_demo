using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tips : MonoBehaviour
{
    public GameObject DialogueUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            EnableDialogueUI();
        }
    }

    private void EnableDialogueUI() {
        DialogueUI.SetActive(true);
    }
}
