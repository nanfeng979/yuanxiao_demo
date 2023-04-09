using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerStatus
{
    Walk,
    Dialogue
}

public class PlayerStatusScript : MonoBehaviour
{
    public static PlayerStatusScript instance;

    private PlayerStatus playerStatus;

    void Start() {
        instance = this;
        Init();
    }


    public PlayerStatus GetPlayerStatus() {
        return playerStatus;
    }

    public void SetPlayerStatus(PlayerStatus playerStatus) {
        this.playerStatus = playerStatus;
    }

    private void Init() {
        playerStatus = PlayerStatus.Walk;
    }
}
