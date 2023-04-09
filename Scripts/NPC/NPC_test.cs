using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_test : MonoBehaviour
{
    public GameObject Tips;
    public GameObject DialogueUI;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Player") {
            // EnableTips();
            // EnableTalk(other.gameObject);
            EnableDialogueUI();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.name == "Player") {
            DisableTips();
            DisableTalk(other.gameObject);
        }
    }

    private void EnableDialogueUI() {
        DialogueUI.SetActive(true);
    }

    private void EnableTips() {
        Tips.SetActive(true);
    }

    private void DisableTips() {
        Tips.SetActive(false);
    }

    private void EnableTalk(GameObject obj) {
        obj.GetComponent<Player>().canTalk();
    }

    private void DisableTalk(GameObject obj) {
        obj.GetComponent<Player>().notTalk();
    }
}
