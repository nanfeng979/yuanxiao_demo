using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private float InputX;
    private float InputY;
    private float MoveSpeed = 3.0f;

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(PlayerStatusScript.instance.GetPlayerStatus() != PlayerStatus.Walk) {
            anim.SetBool("Move", false);
            anim.SetFloat("InputX", 0);
            anim.SetFloat("InputY", 0);
            return;
        }

        InputX = Input.GetAxis("Horizontal");
        InputY = Input.GetAxis("Vertical");


        Vector2 InputDir = new Vector2(InputX, InputY);
        if(InputDir != Vector2.zero) {
            if(Mathf.Abs(InputX) > Mathf.Abs(InputY)) {
                transform.Translate(new Vector2(InputX, 0) * MoveSpeed * Time.deltaTime);
                
            } else {
                transform.Translate(new Vector2(0, InputY) * MoveSpeed * Time.deltaTime);
            }

            anim.SetBool("Move", true);
        } else {
            anim.SetBool("Move", false);
        }

        anim.SetFloat("InputX", InputDir.x);
        anim.SetFloat("InputY", InputDir.y);
    }
}
