using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheGiantFace : MonoBehaviour
{
    private int playerCount = 1;
    public GameObject wallDozer;
    public float startTime = 10f;
    public float duration;

    private void Start()
    {
        duration = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (duration <= 0)
        {
            Instantiate(wallDozer, new Vector3(-6, 12, 0), Quaternion.identity);
            Instantiate(wallDozer, new Vector3(6, 12, 0), Quaternion.identity);
            duration = startTime;
        }
        else {
            duration -= Time.deltaTime;
        }
    }
}
