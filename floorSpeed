using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorSpeed : MonoBehaviour
{
    public float speed = 15f;
    void Update()
    {
        if (transform.position.x >= -7)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime, Space.World);
        }
        else
        {
            transform.position = new Vector2(0, transform.position.y);
        }
    }
}
