using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyAttack : MonoBehaviour
{
    public float speed = 50f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);

        if (transform.position.y <= -15) {
            Destroy(gameObject);
        }
    }
}
