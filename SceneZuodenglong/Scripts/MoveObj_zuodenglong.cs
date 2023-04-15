using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj_zuodenglong : MonoBehaviour
{
    public string typeName;
    public float offset = 0.5f;
    [SerializeField] private GameObject adsorptionList;
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

        for(int i = 0; i < adsorptionList.transform.childCount; i++) {
            if(Vector2.Distance(transform.position, adsorptionList.transform.GetChild(i).position) < offset) {
                if(adsorptionList.transform.GetChild(i).name == typeName) {
                    transform.position = adsorptionList.transform.GetChild(i).position;
                }
            }
        }
        
    }

    private void moveObj() {
        Vector3 newMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 distance = newMousePosition - oldMousePosition;
        distance.z = 0;
        transform.position += distance;
        Debug.Log(transform.position);
        oldMousePosition = newMousePosition;
    }
}
