using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentEvent : MonoBehaviour
{
    public GameObject TabMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) {
            SetActive(TabMenu);
        }
    }


    private void SetActive(GameObject obj) {
        if(obj.activeSelf) {
            obj.SetActive(false);
        } else {
            obj.SetActive(true);
        }
    }

}
