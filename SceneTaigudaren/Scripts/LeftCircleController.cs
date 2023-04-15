using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeftCircleController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text loseText;
    [SerializeField] private TMP_Text perfactText;
    [SerializeField] private TMP_Text niceText;
    [SerializeField] private TMP_Text goodText;

    [SerializeField] private GameObject rightCircles;
    private GameObject rightCircleFirst;

    [SerializeField] private GameObject loseRightCircleList;

    private float myRadius;
    private float targetRadius;

    private float score = 0;
    private float lost = 0;
    private float perfact = 0;
    private float nice = 0;
    private float good = 0;

    void Start()
    {
        myRadius = transform.localScale.x;
    }

    void Update()
    {
        if(rightCircles.transform.childCount > 0) {
            ClearFirstRightCircle();
        }
    }

    private void ClearFirstRightCircle() {
        rightCircleFirst = rightCircles.transform.GetChild(0).gameObject;
        targetRadius = rightCircleFirst.transform.localScale.x;

        float distanceByTwoCenter = Vector2.Distance(transform.position, rightCircleFirst.transform.position);

        if(distanceByTwoCenter < (myRadius + targetRadius) / 2) {
            if(Input.GetKeyDown(KeyCode.Space)) {
                BeatTheDrum(rightCircleFirst);
                if(distanceByTwoCenter / ((myRadius + targetRadius) / 2) < 0.2f) {
                    perfact += 1;
                    perfactText.text = "Perfact: " + perfact;
                } else if(distanceByTwoCenter / ((myRadius + targetRadius) / 2) < 0.5f) {
                    nice += 1;
                    niceText.text = "Nice: " + nice;
                } else {
                    good += 1;
                    goodText.text = "Good: " + good;
                }
            }
        } else {
            if(transform.position.x > rightCircleFirst.transform.position.x) {
                SetColor(rightCircles.transform.GetChild(0).gameObject);
                rightCircles.transform.GetChild(0).SetParent(loseRightCircleList.transform);
                AddLost(1);
            }
        }
    }

    private void BeatTheDrum(GameObject obj) {
        Destroy(obj);
        AddScore(1);
    }

    private void AddScore(int amount) {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    private void AddLost(int amount) {
        lost += amount;
        loseText.text = "Lost: " + lost;
    }

    private void SetColor(GameObject obj) {
        obj.GetComponent<Renderer>().material.color = Color.black;
    }

}
