using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCircle : MonoBehaviour
{
    public float moveSpeed = 3.0f;
    private Vector2 moveDirection = Vector2.left;
    private float deadTime = 20.0f;

    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

        deadTime -= Time.deltaTime;
        if(deadTime < 0) {
            Destroy(gameObject);
        }
    }
}
