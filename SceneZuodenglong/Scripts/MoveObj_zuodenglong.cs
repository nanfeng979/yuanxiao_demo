using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj_zuodenglong : MonoBehaviour
{
    private Vector3 oldMousePosition;
    private bool canMove = false;
    
    void Update()
    {
        if(canMove) {
            moveObj();
        }
    }

    private void OnMouseDown() {
        oldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        canMove = true;
    }

    private void OnMouseUp() {
        canMove = false;
    }

    private void moveObj() {
        Vector3 newMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 distance = newMousePosition - oldMousePosition;
        distance.z = 0;
        transform.position += distance;

        oldMousePosition = newMousePosition;
    }
}
