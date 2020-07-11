using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damager : MonoBehaviour
{
    public float speed = 15f;
    void Update()
    {
        if (transform.position.y >= -3.5f)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }
}
