using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool Talk = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(Talk && Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Talk");
        }
    }

    public void canTalk() {
        Talk = true;
    }

    public void notTalk() {
        Talk = false;
    }


}
