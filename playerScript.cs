using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 3f;
    public Vector2 MoveInput;
    public int randomValue;
    public GameObject deadBall;
    public int playerCount = 1;

    public GameObject soundEffect;

    public int health = 5;

    void Start()
    {
        Instantiate(soundEffect,transform.position,Quaternion.identity);
    }

    void Update()
    {
        MoveInput = new Vector2(Input.GetAxisRaw("Horizontal"), rb.velocity .y);

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            RandomValueGiver();
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            RandomValueGiver();
        }

        if (health <= 0) {
            Instantiate(deadBall,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
        Destroy(gameObject, 10);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveInput*speed*Time.deltaTime);
    }

    void RandomValueGiver() {
        randomValue = (int)Random.Range(1,3.9f);

        if (randomValue == 1)
        {
            speed = 10f;
        }
        else if (randomValue == 2)
        {
            speed = 30f;
        }
        else if (randomValue == 3)
        {
            speed = 50f;
        }
        else {
            speed = 40f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish")) {
                Instantiate(gameObject, new Vector3(transform.position.x + 2, transform.position.y, transform.position.z), Quaternion.identity);
            health--;
            playerCount++;
        }
    }
}
