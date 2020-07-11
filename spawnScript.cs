using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject obs;
    public float startTime = 3f;
    private float duration;
    private int randomValue;

    private void Start()
    {
        duration = startTime;
    }
    void Update()
    {
        if (duration <= 0)
        {
            Instantiate(obs, new Vector3(valueGenerator(),transform.position.y,transform.position.z),Quaternion.identity);
            duration = startTime;
        }

        else {
            duration -= Time.deltaTime;
        }
    }

    int valueGenerator() {

        randomValue = (int)Random.Range(0f,5f);

        if (randomValue == 0)
        {
            return -6;
        }

        if (randomValue == 1)
        {
            return -3;
        }

        if (randomValue == 2)
        {
            return 0;
        }

        if (randomValue == 3)
        {
            return 3;
        }

        else {
            return 6;
        }
    }
}
