using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cityMoving : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        if (transform.position.x >= -44)
        {
            transform.Translate(Vector2.left * speed* Time.deltaTime, Space.World);
        }
        else {
            transform.position = new Vector2(0,0);
        }
    }
}
