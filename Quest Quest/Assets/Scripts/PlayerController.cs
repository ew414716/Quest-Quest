using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public PlayerLevel level;
    public float moveSpeed = 5;
    public float turnSpeed = 5;
    public float thrustForce = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        level = gameObject.GetComponent<PlayerLevel>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
        }
    }

   public void OnLevelUp()
    {
        moveSpeed += 1.5f;
    }

    //On collision with an object tagged with "Teleport" & an empty game object as its first child, this will teleport the player to the empty
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Teleport")
        {
            transform.position = col.transform.GetChild(0).position;
        }
    }
}


