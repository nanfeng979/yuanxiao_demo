using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_test : MonoBehaviour
{
    public GameObject Tips;
    

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name == "Player") {
            EnableTips();
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.name == "Player") {
            DisableTips();
        }
    }

    

    private void EnableTips() {
        Tips.SetActive(true);
    }

    private void DisableTips() {
        Tips.SetActive(false);
    }

}
