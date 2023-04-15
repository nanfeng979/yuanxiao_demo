using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCirclesManager : MonoBehaviour
{
    [SerializeField] private GameObject rightCirclePrefab;
    private float createNextCircleTime;
    private float nextCircleTimer = 0.0f;

    void Start()
    {
        createNextCircleTime = 1.0f;
    }

    void Update()
    {
        nextCircleTimer += Time.deltaTime;
        if (nextCircleTimer >= createNextCircleTime) {
            CreateCircle();
            createNextCircleTime = Random.Range(0.5f, 1.0f);
            // createNextCircleTime = 1;
            nextCircleTimer -= createNextCircleTime;
        }
    }

    private void CreateCircle() {
        Instantiate(rightCirclePrefab, transform.position, Quaternion.identity, gameObject.transform);
    }
}
